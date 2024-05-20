using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Task4 : Form
    {
        public Task4()
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
       

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string url = NormalSource(txtURL.Text);
            if (getSource(url) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                WebClient myClient = new WebClient();
                Stream respone = myClient.OpenRead(url);
                StreamReader sr = new StreamReader(respone);
                string responeFromServer = sr.ReadToEnd();



                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.html";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    try
                    {
                        myClient.DownloadFile(url, filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
                MessageBox.Show("Tải xuống thành công!", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
     
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            string url = NormalSource(txtURL.Text);
            if (getSource(url) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SourceCode source = new SourceCode(url);
                source.Show();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            
            string url = NormalSource(txtURL.Text);
            string source = getSource(url);

            if (source == "URL không hợp lệ!" || source == "Không thể kết nối đến URL!" || source == "Đã xảy ra lỗi khi tải nội dung!")
            {
                MessageBox.Show(source, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị nội dung HTML trong WebView2
                webView21.Source = new Uri(url);
            }
        }
        private async void btnDownIMG_Click(object sender, EventArgs e)
        {
            string url = NormalSource(txtURL.Text);

            if (getSource(url) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        string downloadPath = folderBrowserDialog.SelectedPath; // Đường dẫn thư mục để lưu trữ hình ảnh
                        //string url = txtURL.Text;

                        try
                        {
                            await DownloadImagesFromUrl(url, downloadPath);

                            MessageBox.Show("Tải xuống hoàn tất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một thư mục hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }    
            
        }

        private async Task DownloadImagesFromUrl(string url, string downloadPath)
        {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDocument = htmlWeb.Load(url);

            // Lấy tất cả các thẻ <img>
            HtmlNodeCollection imageNodes = htmlDocument.DocumentNode.SelectNodes("//img");

            if (imageNodes != null)
            {
                int successCount = 0;
                int failCount = 0;

                foreach (HtmlNode imageNode in imageNodes)
                {
                    string imageUrl = imageNode.GetAttributeValue("src", "");

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        // Chuyển đổi đường dẫn tương đối thành đường dẫn tuyệt đối
                        if (!Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
                        {
                            Uri baseUri = new Uri(url);
                            Uri fullUri = new Uri(baseUri, imageUrl);
                            imageUrl = fullUri.ToString();
                        }

                        // Định dạng tên là image+ngaythangnam+extension(.png .jpg...)
                        string fileName = "image" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(imageUrl);
                        string filePath = Path.Combine(downloadPath, fileName);

                        // Tải xuống hình ảnh
                        using (WebClient webClient = new WebClient())
                        {
                            try
                            {
                                await webClient.DownloadFileTaskAsync(new Uri(imageUrl), filePath);
                                successCount++;
                            }
                            catch (Exception ex)
                            {
                                // Ghi lại lỗi và tiếp tục tải các hình ảnh khác
                                failCount++;
                                Console.WriteLine($"Lỗi khi tải xuống hình ảnh từ {imageUrl}: {ex.Message}");
                            }
                        }
                    }
                }

                // Hiển thị thông báo kết quả
                MessageBox.Show($"Tải xuống thành công: {successCount} hình ảnh.\nKhông tải xuống được: {failCount} hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thẻ <img> nào trên trang web.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
