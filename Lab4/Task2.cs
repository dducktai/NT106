using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        private string NormalSource(string URL)
        {
            // Thêm giao thức mặc định nếu không có
            if (!URL.StartsWith("http://") && !URL.StartsWith("https://"))
            {
                URL = "https://" + URL;
                return URL;
            }
            return URL;

        }
        private string getSource(string URL)
        {

            try
            {
                URL = NormalSource(URL);

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument(); // Khởi tạo và tải nội dung trực tiếp
                content = web.Load(URL);
                string s = content.Text;
                return s;  // Trả về nội dung HTML của trang
            }
            catch (UriFormatException)
            {
                return "URL không hợp lệ!";
            }
            catch (System.Net.WebException)
            {
                return "Không thể kết nối đến URL!";
            }
            catch (Exception)
            {
                return "Đã xảy ra lỗi khi tải nội dung!";
            }
        }

        private void Post(string url)
        {
            try
            {
                // Tạo một yêu cầu sử dụng URL có thể nhận yêu cầu POST.
                WebRequest request = WebRequest.Create(url);
                // Thiết lập thuộc tính Method của yêu cầu thành POST.
                request.Method = "POST";

                // Tạo dữ liệu POST và chuyển đổi nó thành một mảng byte.
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Thiết lập thuộc tính ContentType của WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Thiết lập thuộc tính ContentLength của WebRequest.
                request.ContentLength = byteArray.Length;

                // Lấy luồng yêu cầu.
                Stream dataStream = request.GetRequestStream();
                // Ghi dữ liệu vào luồng yêu cầu.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Đóng đối tượng Stream.
                dataStream.Close();

                // Nhận phản hồi từ máy chủ.
                WebResponse response = request.GetResponse();
                // Hiển thị trạng thái của phản hồi (đã bỏ qua trong đoạn mã gốc).


                // Lấy luồng chứa nội dung được trả về bởi máy chủ.
                // Khối using đảm bảo luồng được đóng tự động.
                using (dataStream = response.GetResponseStream())
                {
                    // Mở luồng sử dụng StreamReader để dễ dàng truy cập.
                    StreamReader reader = new StreamReader(dataStream);
                    // Đọc nội dung.
                    string responseFromServer = reader.ReadToEnd();
                    // Hiển thị nội dung.
                    rtbHTML.Text = responseFromServer;
                }

                // Đóng phản hồi.
                response.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi xảy ra.
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string url = NormalSource(txtURL.Text);

            if (getSource(url) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                Post(url);

        }

        private void txbContent_MouseClick(object sender, MouseEventArgs e)
        {
            txbContent.Text = null;
        }

        private void txbContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPost.PerformClick();
            }
        }
    }

}
