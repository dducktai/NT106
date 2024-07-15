using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Lab06
{
    public partial class indexForm : Form
    {
        private Thread thread = null;
        private TcpListener serverSocket;
        private mainForm serverForm = null;
        private int clientsCount = 0, currentRound, timeupCount, startRange, endRange, ansNumber, round = 0;
        private String correctPlayer, time = "";
        private Random rand;
        private bool ingame = false;
        private readonly object _lock = new object();
        private Dictionary<String, int> scoreBoard = new Dictionary<string, int>();
        private Dictionary<String, bool> readyPlayers = new Dictionary<string, bool>();
        private readonly Dictionary<String, TcpClient> clientsList = new Dictionary<string, TcpClient>();

        public indexForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            rand = new Random();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (serverForm != null)
            {
                serverForm.Show();
                return;
            }

            serverForm = new mainForm(this, joinUsername.Text, joinIP.Text, joinPort.Text, time);
            serverForm.Show();

            if (thread == null)
            {
                serverForm = null;
            }
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            btnServer.Enabled = false;
            thread = new Thread(serverThread);
            thread.Start();
        }

        private void serverThread()
        {
            int port;
            try
            {
                port = Int32.Parse(hostPort.Text);
                serverSocket = new TcpListener(IPAddress.Any, port);
                serverSocket.Start();
            }
            catch
            {
                btnServer.Invoke(new MethodInvoker(delegate ()
                {
                    btnServer.Enabled = true;
                }));
                MessageBox.Show("Lỗi port!");
                return;
            }

            time = DateTime.Now.ToString("h:mm:ss tt");

            this.Invoke(new MethodInvoker(delegate ()
            {
                joinUsername.Text = "Server";
                joinIP.Text = "localhost";
                joinPort.Text = hostPort.Text;
                joinUsername.Enabled = joinIP.Enabled = joinPort.Enabled = hostPort.Enabled = false;
            }));

            (new Thread(() => this.Invoke(new MethodInvoker(delegate ()
            {
                btnClient.PerformClick();
            })))).Start();

            MessageBox.Show("Tạo game mới thành công");

            while (Thread.CurrentThread.IsAlive)
            {
                TcpClient client = null;
                try
                {
                    client = serverSocket.AcceptTcpClient();
                }
                catch (SocketException e)
                {
                    if ((e.SocketErrorCode == SocketError.Interrupted))
                    {
                        break;
                    }
                }

                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesCount = stream.Read(buffer, 0, buffer.Length);
                String username = Encoding.UTF8.GetString(buffer, 0, bytesCount);

                if (thread != null && ingame)
                {
                    buffer = Encoding.UTF8.GetBytes("@@@Ingame!@@@");
                    stream.Write(buffer, 0, buffer.Length);
                    continue;
                }

                if (username == " ")
                {
                    username = $"Player {clientsCount}";
                }

                if (clientsList.ContainsKey(username))
                {
                    buffer = Encoding.UTF8.GetBytes(" ");
                    stream.Write(buffer, 0, buffer.Length);
                    continue;
                }
                buffer = Encoding.UTF8.GetBytes(username);
                stream.Write(buffer, 0, buffer.Length);

                lock (_lock) clientsList.Add(username, client);
                if (username != "Server")
                {
                    broadcast($"m>>> {username} vừa vào phòng chơi", username);
                    scoreBoard.Add(username, 0);
                }

                clientsCount++;

                Thread handlingThread = new Thread(o => clientCheck((string)o));
                handlingThread.Start(username);
                broadcast($"\t{clientsList.Count - 1}");
            }

            btnServer.Invoke(new MethodInvoker(delegate ()
            {
                btnServer.Enabled = true;
                btnServer.ResetText();
            }));
        }

        // Set số round cho mỗi game và khoảng số cần đoán
        private void roundStart()
        {
            Thread.Sleep(2000);
            timeupCount = 0;

            if (round == 0)
            {
                round = rand.Next(3, 10);
                broadcast($"mTrò chơi có {round} round");
                currentRound = 1;
            }

            startRange = rand.Next(0, 50);
            endRange = startRange + rand.Next(1, 50);
            ansNumber = rand.Next(startRange, endRange + 1);
            broadcast($"m>>> Round {currentRound}: Đoán một số trong khoảng [{startRange}, {endRange}].\n@@@Nextround!@@@{rand.Next(5, 11)}\t{startRange}\t{endRange}\t{ansNumber}");
            currentRound++;
            correctPlayer = "";
        }

        private void timeUp()
        {
            string message;
            if (correctPlayer == "") message = $"mKhông ai có đáp án chính xác";
            else message = $"m{correctPlayer} là người chơi đưa ra đáp án nhanh nhất, +10 điểm";
            broadcast($"{message}\nmĐáp án là: {ansNumber}.\nm------------------------------");
            if (currentRound > round) (new Thread(endGame)).Start();
            else if (ingame) (new Thread(roundStart)).Start();
        }

        public void clientCheck(string username)
        {
            TcpClient client;
            lock (_lock) client = clientsList[username];
            while (thread.IsAlive)
            {
                int bytesCount = 0;
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                try
                {
                    bytesCount = stream.Read(buffer, 0, buffer.Length);
                }
                catch { }
                if (bytesCount == 0) break;

                string requestFromClient = Encoding.UTF8.GetString(buffer, 0, bytesCount);
                var dataList = requestFromClient.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String data in dataList)
                    if (data[0] == 's')
                    {
                        if (correctPlayer == "" && timeupCount < readyPlayers.Count)
                            try
                            {
                                int ans = Int32.Parse(data.Substring(1));
                                if (ans == ansNumber)
                                {
                                    correctPlayer = username;
                                    scoreBoard[username] += 10;
                                    broadcast($"mĐã tìm thấy người chơi chiến thắng tại round {currentRound - 1}");
                                }
                                if (ans != ansNumber)
                                {
                                    broadcast($"m{username} đoán sai! ({ans}). -1 điểm");
                                    scoreBoard[username]--;
                                }
                            }
                            catch
                            {
                                broadcast($"m{username} nhập đáp án không hợp lệ. -1 điểm");
                                scoreBoard[username]--;
                            }
                    }
                    else if (data[0] == 'm')
                    {
                        broadcast($"m{username}: {data.Substring(1)}");
                    }
                    else if (data == "@@@Timeup!@@@")
                    {
                        timeupCount++;
                        if (timeupCount == readyPlayers.Count) (new Thread(() => timeUp())).Start();
                    }
                    else if (data == "@@@Ready!@@@")
                    {
                        broadcast($"m>>> {username} đã sẵn sàng!");
                        readyPlayers.Add(username, true);
                        readyCheck();
                    }
            }

            lock (_lock) clientsList.Remove(username);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();

            if (username == "Server")
            {
                broadcast("@@@Exit!@@@");
            }
            else
            {
                broadcast($"m>>> {username} đã thoát khỏi game");
                if (clientsList.Count == 1)
                {
                    broadcast($"m>>> Tất cả người chơi đã thoát khỏi game");
                    if (ingame)
                    {
                        ingame = false;
                        endGame();
                    }
                }
                broadcast($"\t{clientsList.Count - 1}");
                scoreBoard.Remove(username);
                if (readyPlayers.ContainsKey(username)) readyPlayers.Remove(username);
                readyCheck();
            }
        }

        private void readyCheck()
        {
            if (readyPlayers.Count != 0 && readyPlayers.Count == clientsList.Count - 1)
            {
                ingame = true;
                broadcast($"mHiện có {readyPlayers.Count} người chơi");
                (new Thread(roundStart)).Start();
            }
        }

        private void endGame()
        {
            if (ingame)
            {
                ingame = false;
                int highscore = int.MinValue;
                foreach (var i in scoreBoard)
                {
                    if (i.Value > highscore)
                    {
                        highscore = i.Value;
                    }
                }

                string message = $"mĐiểm cao nhất là: {highscore}\nNgười chơi có điểm cao nhất:\n";
                foreach (var i in scoreBoard)
                {
                    if (i.Value == highscore)
                    {
                        message += $"m  + {i.Key}\n";
                    }
                }

                foreach (var i in clientsList)
                {
                    try
                    {
                        NetworkStream stream = i.Value.GetStream();
                        byte[] buffer;
                        if (i.Key == "Server")
                        {
                            buffer = Encoding.UTF8.GetBytes($"{message}\n");
                        }
                        else
                        {
                            buffer = Encoding.UTF8.GetBytes($"{message}\nmĐiểm của bạn: {scoreBoard[i.Key]}\n");
                        }
                        stream.Write(buffer, 0, buffer.Length);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Lỗi: {e.Message}");
                    }
                }
            }

            broadcast($"m=================\nm\nmTạo game mới...\nmChờ người chơi tham gia...\n@@@Newgame!@@@");
            scoreBoard = scoreBoard.ToDictionary(p => p.Key, p => 0);
            round = 0;
            readyPlayers.Clear();
        }

        public void broadcast(string data, String except = "")
        {
            byte[] buffer = Encoding.UTF8.GetBytes($"{data}\n");
            lock (_lock)
            {
                foreach (var c in clientsList)
                {
                    if (c.Key != except)
                    {
                        NetworkStream stream = c.Value.GetStream();
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ingame)
            {
                MessageBox.Show("Chờ game hiện tại kết thúc");
                e.Cancel = true;
                return;
            }

            if (serverForm != null)
            {
                this.Hide();

                String text = $">>> {time} - Server hosted a connection... <<<\n\n{serverForm.conversation.Text}\n>>> Connection closed <<<\n\n\n\n";
                (new saveHistory(text)).ShowDialog();
                serverForm.isServer = serverForm.isIngame = false;
                serverForm.Close();
            }

            if (serverSocket != null)
            {
                serverSocket.Stop();
            }

            if (thread != null)
            {
                thread.Abort();
            }
        }
    }
}

