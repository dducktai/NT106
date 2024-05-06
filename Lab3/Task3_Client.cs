using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Task3_Client : Form
    {
        public Task3_Client()
        {
            InitializeComponent();
        }
        private bool isInChat = false;
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu networkStream không null và có thể ghi
            if (networkStream != null && networkStream.CanWrite)
            {
                // Gửi tin nhắn
                Byte[] data = Encoding.UTF8.GetBytes("Hello Server \r\n");
                try
                {
                    networkStream.Write(data, 0, data.Length);
                }
                catch (IOException ex)
                {
                    // Xử lý trường hợp kết nối đã đóng
                    MessageBox.Show("Không thể gửi tin nhắn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSend.Enabled = false; // Vô hiệu hóa phím gửi tin nhắn
                }
            }
        }
        private void Task3_Client_Load(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);

            tcpClient.Connect(ipEndPoint);
            networkStream = tcpClient.GetStream();
            isInChat = true;
        }

        private void Task3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Task3_Client_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (networkStream != null)
                    {
                        Byte[] data = Encoding.ASCII.GetBytes("Quit\n");
                        networkStream.Write(data, 0, data.Length);
                        networkStream.Close();
                    }

                    if (tcpClient != null)
                    {
                        tcpClient.Close();
                    }
                }

            }




        }
    }
}
