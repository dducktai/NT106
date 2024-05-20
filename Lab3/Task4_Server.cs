using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task4_Server : Form
    {
        public Task4_Server()
        {
            InitializeComponent();
        }
        private bool isServerRunning = false;
        private TcpListener tcpListener;
        private List<TcpClient> clients = new List<TcpClient>();
        private void AppendLog(string message)
        {
            // Hiển thị tin nhắn lên giao diện trong list view
            if (lvLog.InvokeRequired)
            {
                lvLog.Invoke(new MethodInvoker(delegate { lvLog.Items.Add(message + Environment.NewLine); }));
            }
            else
            {
                lvLog.Items.Add(message + Environment.NewLine);
            }
        }
        private void BroadcastMessage(string message, TcpClient excludedClient = null)
        {

            // Broadcast tin nhắn tới tất cả client
            foreach (TcpClient client in clients)
            {
                if (client != excludedClient)
                {
                    NetworkStream clientStream = client.GetStream();
                    StreamWriter writer = new StreamWriter(clientStream);
                    writer.WriteLine(message);
                    writer.Flush();
                }
            }
            // Hiển thị tin nhắn lên giao diện
            AppendLog(message);
        }
        private void AddClient(TcpClient tcpClient, string userName)
        {
            // Thêm client vào danh sách
            clients.Add(tcpClient);
            // Hiển thị thông tin đăng nhập của client lên giao diện
            AppendLog(userName + " đã kết nối!");
            // Broadcast tin nhắn chào mừng tới tất cả client, trừ client mới kết nối
            BroadcastMessage(userName + " đã tham gia cuộc trò chuyện.", tcpClient);
        }
        private void RemoveClient(TcpClient tcpClient, string userName)
        {

            // Xóa client khỏi danh sách
            clients.Remove(tcpClient);

            // Hiển thị thông tin đăng xuất của client lên giao diện
            AppendLog(userName + " đã ngắt kết nối!");

            // Broadcast tin nhắn thông báo client đã đăng xuất tới tất cả client, trừ client đã đăng xuất
            BroadcastMessage(userName + " đã rời khỏi cuộc trò chuyện.", tcpClient); // Chỉ broadcast nếu client vẫn đang kết nối

            // Gọi lại AppendLog để hiển thị tin nhắn trên giao diện của server
            if (tcpClient.Connected)
            {
                AppendLog(userName + " đã rời khỏi cuộc trò chuyện.");
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            StreamReader reader = new StreamReader(clientStream);
            StreamWriter writer = new StreamWriter(clientStream);
            string userName = reader.ReadLine(); // Đọc tên người dùng từ client
            AddClient(tcpClient, userName); // add client với tên người dùng

            while (tcpClient.Connected) // Kiểm tra trạng thái kết nối
            {
                try
                {
                    string message = reader.ReadLine();
                    if (message == null)
                        break;


                    // Xử lý tin nhắn từ client, ví dụ: broadcast cho toàn bộ client
                    BroadcastMessage(userName + ": " + message);
                }
                catch (IOException)
                {
                    // Xóa client khỏi danh sách khi client đóng kết nối
                    RemoveClient(tcpClient, userName);
                    break;
                }
            }

            // Đóng kết nối và xóa client khi client đóng kết nối
            tcpClient.Close();
            RemoveClient(tcpClient, userName);
        }
        private void ListenForClients()
        {
            while (true)
            {
                try
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    Thread clientThread = new Thread(start: HandleClientComm);
                    clientThread.Start(tcpClient);
                }
                catch (SocketException ex)
                {
                    // Bắt ngoại lệ SocketException khi dừng lắng nghe kết nối từ client
                    //MessageBox.Show(ex.Message, "Lỗi, không kết nối được!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
        }

        private void StartServer()
        {
            try
            {
                // Khởi tạo và bắt đầu lắng nghe kết nối từ client
                tcpListener = new TcpListener(IPAddress.Any, 8080);
                tcpListener.Start();
                AppendLog("Server đang lắng nghe...");
                Thread listenThread = new Thread(ListenForClients);
                listenThread.Start();
                isServerRunning = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Lỗi, không kết nối được!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnListen_Click(object sender, EventArgs e)
        {

            StartServer();
            BroadcastMessage("SERVER_OPEN");

            btnClose.Enabled = true;
            btnListen.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                // Thông báo cho tất cả các client rằng máy chủ đã đóng
                BroadcastMessage("SERVER_CLOSE");
                // Dừng lắng nghe kết nối mới
                tcpListener.Stop();

                //// Đóng tất cả các kết nối hiện tại
                //foreach (TcpClient client in clients)
                //{
                //    client.Close();
                //}

                // Xóa danh sách client
                clients.Clear();



                // Hiển thị thông báo lên giao diện
                AppendLog("Đã đóng tất cả kết nối và dừng lắng nghe!");
                btnClose.Enabled = false;
                btnListen.Enabled = true;
                isServerRunning = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đóng kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Task4_Server_Load(object sender, EventArgs e)
        {
            btnClose.Enabled = false;
        }

        private void Task4_Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận khi người dùng cố gắng đóng Form
            DialogResult result;
            if (isServerRunning == true)
            {
                result = MessageBox.Show("Bạn có muốn đóng máy chủ không?", "Xác nhận đóng máy chủ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }
            else
            {
                result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát chương trình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            }

            // Nếu người dùng chọn "Cancel", hủy việc đóng Form
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            // Nếu người dùng chọn "OK", đóng Form và dừng server (nếu cần)
            else if (result == DialogResult.OK)
            {
                if (isServerRunning == true)
                {
                    // Dừng server hoặc thực hiện các thao tác cần thiết trước khi đóng
                    btnClose_Click(this, e);
                }

            }
        }
    }
}
