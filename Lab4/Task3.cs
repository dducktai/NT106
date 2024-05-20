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
using HtmlAgilityPack;

namespace Lab4
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        //private string NormalSource(string URL)
        //{
        //    // Thêm giao thức mặc định nếu không có
        //    if (!URL.StartsWith("http://") && !URL.StartsWith("https://"))
        //    {
        //        URL = "https://" + URL;
        //        return URL;
        //    }
        //    return URL;

        //}
        //private string getSource(string URL)
        //{

        //    try
        //    {
        //        URL = NormalSource(URL);

        //        HtmlWeb web = new HtmlWeb();
        //        HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument(); // Khởi tạo và tải nội dung trực tiếp
        //        content = web.Load(URL);
        //        string s = content.Text;
        //        return s;  // Trả về nội dung HTML của trang
        //    }
        //    catch (UriFormatException)
        //    {
        //        return "URL không hợp lệ!";
        //    }
        //    catch (System.Net.WebException)
        //    {
        //        return "Không thể kết nối đến URL!";
        //    }
        //    catch (Exception)
        //    {
        //        return "Đã xảy ra lỗi khi tải nội dung!";
        //    }
        //}

        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(txtURL.Text);
            myClient.DownloadFile(txtURL.Text, txtPath.Text);

            string content = new StreamReader(response).ReadToEnd();
            rtbHTML.Text = content;
        }
    }
}
