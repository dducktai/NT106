using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace Lab06
{
    public partial class mainForm : Form
    {
        private TcpClient client = null;
        private Thread thread = null;
        private indexForm parent;
        private Random rand;
        private String joinUsername, joinIP, joinPort, time;
        private int timeLeft = -1, valRange, lastSubmitTime, startRange, endRange;
        public bool isIngame = false, isServer = false, isAuto = false;
        private List<int> ansList = null;

        public mainForm(indexForm parent, string joinUsername, string joinIP, string joinPort, String time)
        {
            InitializeComponent();
            rand = new Random();
            this.joinPort = joinPort;
            this.time = time;
            this.joinUsername = joinUsername;
            this.joinIP = joinIP;
            this.MaximizeBox = false;
            this.parent = parent;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            answer.AutoSize = true;
            string username = joinUsername;
            IPAddress ip = null;
            int port = 0;
            if (username == "Username" || username == "") username = " ";
            try
            {
                ip = Dns.Resolve(joinIP).AddressList[0];
                port = Int32.Parse(joinPort);
            }
            catch
            {
                MessageBox.Show("Sai địa chỉ IP!");
                this.Close();
                return;
            }
            client = new TcpClient();
            try
            {
                client.Connect(ip, port);
            }
            catch
            {
                MessageBox.Show("Không có game nào đang diễn ra!");
                this.Close();
                return;
            }


            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(username);
            stream.Write(buffer, 0, buffer.Length);

            buffer = new byte[1024];
            int bytesCount = stream.Read(buffer, 0, buffer.Length);
            string res = Encoding.UTF8.GetString(buffer, 0, bytesCount);
            String[] ress = res.Split('\t');

            if (ress[0] == "Server")
            {
                isServer = true;
                btnReady.Enabled = btnSubmit.Enabled = btnAutoplayWholeGame.Enabled = btnAutoPlaySingleTurn.Enabled = btnClear.Enabled = label1.Enabled = false;
                answer.BorderStyle = BorderStyle.None;
            }
            else if (ress[0] == "@@@Ingame!@@@")
            {
                MessageBox.Show("Trò chơi đã bắt đầu, không thể vào!", "Error");
                this.Close();
                return;
            }
            else if (ress[0] == " ")
            {
                MessageBox.Show($"{username} không thể dùng được", "Error");
                this.Close();
                return;
            }

            if (!isServer)
            {
                MessageBox.Show($"{ress[0]} là tên của bạn", "Success");
                time = DateTime.Now.ToString("h:mm:ss tt");
            }

            this.Text = ress[0];
            if (ress.Length > 1) playerNum.Text = $"{ress[1].Trim('\n')} người chơi đã tham gia";

            thread = new Thread(o => ReceiveData((TcpClient)o));
            thread.Start(client);
        }

        private void send(String message)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes($"{message}\n");
            stream.Write(buffer, 0, buffer.Length);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft > -1)
            {
                timerCnt.Text = timeLeft.ToString();
                if (timeLeft == 0)
                {
                    btnSubmit.Enabled = btnAutoplayWholeGame.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = label3.Enabled = label4.Enabled = range.Enabled = ansNumber.Enabled = false;
                    send("@@@Timeup!@@@");
                }
                else if (isAuto && lastSubmitTime - timeLeft >= 3)
                {
                    new Thread(() => autoSubmit()).Start();
                }
                else if (!isAuto && lastSubmitTime - timeLeft >= 3)
                {
                    btnSubmit.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = true;
                    answer.Focus();
                    answer.Select();
                }
            }
            else
            {
                timerCnt.Text = "X";
                timer.Stop();
            }
        }

        private void answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            btnReady.Enabled = false;
            send("@@@Ready!@@@");
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void submit(int val)
        {
            if (timeLeft <= 0 || lastSubmitTime - timeLeft < 3)
            {
                return;
            }

            new Thread(() => send($"s{val}")).Start();

            lastSubmitTime = timeLeft;

            if (!this.InvokeRequired)
            {
                btnSubmit.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = false;
            }

            int index = ansList.IndexOf(val);

            if (index != -1 && index <= valRange)
            {
                int temp = ansList[valRange];
                ansList[valRange] = ansList[index];
                ansList[index] = temp;
                valRange--;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submit(Int32.Parse(answer.Text));
            answer.Clear();
        }

        private void autoSubmit()
        {
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate ()
                {
                    autoSubmit();
                }));
            else
            {
                btnSubmit.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = false;
                if (isAuto)
                {
                    btnAutoplayWholeGame.Enabled = false;
                }
                int val = rand.Next(0, valRange + 1);
                submit(ansList[val]);
            }
        }

        private void autoTurn_Click(object sender, EventArgs e)
        {
            autoSubmit();
        }

        private void autoAllGame_Click(object sender, EventArgs e)
        {
            isAuto = true;
            autoSubmit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send($"m{message.Text}");
            message.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            conversation.Clear();
        }


        private void ReceiveData(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int bytesCount;

            while (Thread.CurrentThread.IsAlive)
            {
                try
                {
                    if ((bytesCount = stream.Read(receivedBytes, 0, receivedBytes.Length)) <= 0) break;
                }
                catch { break; }
                string respondFromServer = Encoding.UTF8.GetString(receivedBytes, 0, bytesCount);
                var dataList = respondFromServer.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String data in dataList)
                {
                    if (data[0] == 'm')
                        conversation.Invoke(new MethodInvoker(delegate ()
                        {
                            conversation.AppendText($"{data.Substring(1)}\n");
                            conversation.ScrollToCaret();
                        }));
                    else if (data[0] == '\t')
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            playerNum.Text = $"{data.Substring(1)} người chơi đã tham gia";
                        }));

                    else if (data.StartsWith("@@@Nextround!@@@"))
                    {
                        if (!isIngame) isIngame = true;

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            label3.Enabled = range.Enabled = true;
                        }));

                        var rand = data.Substring(16).Split(new String[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                        startRange = Int32.Parse(rand[1]);
                        endRange = Int32.Parse(rand[2]);
                        valRange = endRange - startRange;
                        ansList = Enumerable.Range(startRange, valRange + 1).ToList();
                        range.Invoke(new MethodInvoker(delegate ()
                        {
                            range.Text = $"[{startRange}, {endRange}]";
                        }));

                        if (isServer) ansNumber.Invoke(new MethodInvoker(delegate ()
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                label4.Enabled = ansNumber.Enabled = true;
                            }));
                            ansNumber.Text = rand[3];
                        }));
                        else
                        {
                            lastSubmitTime = 100;
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                btnSubmit.Enabled = btnAutoplayWholeGame.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = true;
                                answer.Focus();
                                answer.Select();
                            }));
                        }

                        timeLeft = int.Parse(rand[0]);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            timerCnt.Text = timeLeft.ToString();
                            timer.Start();
                        }));
                    }
                    else if (!isServer && data == "@@@Newgame!@@@")
                    {
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            btnReady.Enabled = true;
                            btnSubmit.Enabled = btnAutoplayWholeGame.Enabled = btnAutoPlaySingleTurn.Enabled = answer.Enabled = false;
                        }));
                        isIngame = isAuto = false;
                    }
                    else if (data == "@@@Exit!@@@")
                    {
                        closeWhenServerDown();
                        break;
                    }
                }
            }
            if (isIngame)
            {
                isIngame = false;
                closeWhenServerDown();
            }
            stream.Close();
        }

        private void closeWhenServerDown()
        {
            MessageBox.Show("Game hiện tại đã kết thúc");
            (new Thread(() => this.Invoke(new MethodInvoker(delegate ()
            {
                this.Close();
            })))).Start();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isServer)
            {
                this.Hide();
                parent.Show();
                e.Cancel = true;
                return;
            }
            else if (isIngame)
            {
                e.Cancel = true;
                new Thread(() => MessageBox.Show("Vui lòng chờ round hiện tại kết thúc", "Error")).Start();
                return;
            }

            if (this.Text != "Anonymous")
            {
                try
                {
                    String path = Path.Combine(
                        Path.GetDirectoryName(Application.ExecutablePath),
                        $"History_{this.Text}.txt"
                    );
                    StreamWriter sw;
                    if (!File.Exists(path))
                    {
                        sw = File.CreateText(path);
                    }
                    else
                    {
                        sw = File.AppendText(path);
                    }
                    String hostOrJoin;
                    if (this.Text == "Server")
                    {
                        hostOrJoin = $">>> {time} - Server hosted a connection... <<<";
                    }
                    else
                    {
                        hostOrJoin = $">>> {time} - {this.Text} connected to Server... <<<";
                    }
                    conversation.Text = $"{hostOrJoin}\n\n{conversation.Text}\n>>> Connection closed <<<\n\n\n\n";
                    foreach (String line in conversation.Lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể lưu lịch sử", "Error");
                }
            }

            thread?.Abort();

            if (client != null)
            {
                try
                {
                    client.Client.Shutdown(SocketShutdown.Send);
                }
                catch { }
                client.Close();
            }

            parent.Show();
        }
    }
}
