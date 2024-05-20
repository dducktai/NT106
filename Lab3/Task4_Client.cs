using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task4_Client : Form
    {
        private TcpClient client;
        private StreamReader reader;
        private StreamWriter writer;
        private Thread receiveThread;
        private string username;
        private bool isInChat = false;
        public Task4_Client()
        {
            InitializeComponent();
        }
        private void Task4_Client_Load(object sender, EventArgs e)
        {
            btnDisconect.Enabled = false;
            btnSend.Enabled = false;
        }
        private void AddMessage(string log)
        {
            if (lvMess.InvokeRequired)
            {
                lvMess.Invoke(new Action<string>(AddMessage), log);
            }
            else
            {
                lvMess.Items.Add(log + Environment.NewLine);
            }
        }

        private void ReceiveMessages()
        {

            try
            {
                while (client.Connected)
                {
                    // Đọc tin nhắn từ server

                    string message = reader.ReadLine();
                    if (message == "SERVER_CLOSE")
                    {
                        AddMessage("Máy chủ đã đóng!");
                        btnDisconect_Click(this, EventArgs.Empty);
                        btnConnect.Enabled = false;

                        break;
                    }
                    else
                    {
                        // Hiển thị tin nhắn lên client
                        AddMessage(message);
                    }

                }
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ mà không hiển thị thông báo lỗi cụ thể
                MessageBox.Show("Đã rời khỏi cuộc trò chuyện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private bool ConnectToServer()
        {
            // Khởi tạo kết nối đến server
            client = new TcpClient();
            client.Connect("127.0.0.1", 8080); // Kết nối đến địa chỉ IP và cổng của server

            // Khởi tạo StreamReader và StreamWriter để đọc/ghi dữ liệu với server
            NetworkStream stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);

            // Nhập username từ người dùng
            username = textBoxUserName.Text;

            if (string.IsNullOrEmpty(username)) // Kiểm tra nếu không nhập username
            {
                MessageBox.Show("Vui lòng nhập username để tham gia cuộc trò chuyện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                // Gửi username lên server để đăng ký
                writer.WriteLine(username);
                writer.Flush();

                // Khởi tạo thread để lắng nghe dữ liệu từ server
                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();
                return true;
            }


        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConnectToServer() == true)
                {
                    btnConnect.Enabled = false;
                    btnDisconect.Enabled = true;
                    btnSend.Enabled = true;
                    isInChat = true;
                }
                else
                {
                    btnConnect.Enabled = true;
                }
            }
            catch (Exception)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Máy chủ chưa mở!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            // Ngắt kết nối với server

            client.Close();

            // Kiểm tra trạng thái kết nối
            if (!client.Connected)
            {
                // Đóng các tài nguyên khác liên quan đến kết nối
                reader.Close();
                writer.Close();
                if (receiveThread != null && receiveThread.IsAlive)
                {
                    receiveThread.Abort();
                    receiveThread = null;
                }

                btnConnect.Enabled = true;
                btnSend.Enabled = false;
                btnDisconect.Enabled = false;
                isInChat = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username)) // Kiểm tra nếu chưa nhập username
            {
                MessageBox.Show("Vui lòng nhập username trước khi gửi tin nhắn.");
            }
            else
            {
                // Gửi tin nhắn lên server kèm theo username
                writer.WriteLine(tbMes.Text);
                writer.Flush();
                tbMes.Clear();
            }

        }

        private void Task4_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận khi người dùng cố gắng đóng Form
            DialogResult result;
            if (isInChat == true)
            {
                result = MessageBox.Show("Bạn có muốn rời khỏi cuộc trò chuyện không?", "Rời khỏi cuộc trò chuyện", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                if (isInChat == true)
                {
                    // Dừng server hoặc thực hiện các thao tác cần thiết trước khi đóng
                    btnDisconect_Click(this, e);
                }

            }
        }
    }
}
