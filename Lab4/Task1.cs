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

namespace Lab4
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private string getSource(string URL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument content = new HtmlAgilityPack.HtmlDocument();
                content = web.Load(URL);
                string s = content.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }

        private string GetHTML(string szURL)
        {
            try
            {
                // Create a request for the URL.
                WebRequest request = WebRequest.Create(szURL);
                // Get the response.
                WebResponse response = request.GetResponse();
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Close the response.
                response.Close();
                return responseFromServer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "nothing";
            }

        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (getSource(txtURL.Text) == "URL không tồn tại!")
            {
                MessageBox.Show("URL không tồn tại!");
            }
            else
                rtbHTML.Text = GetHTML(txtURL.Text);
        }
    }
}
