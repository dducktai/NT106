using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Lab06
{
    public partial class saveHistory : Form
    {
        private string text;

        public saveHistory(string text)
        {
            InitializeComponent();
            this.text = text;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void saveHistory_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://ctxt.io/");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.Url.ToString() == "https://ctxt.io/")
            {
                HtmlElement editable = getData("div", "className", "editable");
                editable.InnerHtml = "";
                string[] lines = text.Split('\n');
                foreach (string line in lines)
                {
                    editable.InnerHtml += $"{line}<br>";
                }
                getData("select", "className", "select").SetAttribute("value", "1d");
                getData("input", "className", "button").InvokeMember("click");
            }
            else
            {
                string url = webBrowser1.Url.ToString();
                MessageBox.Show($"Lịch sử trò chơi được lưu tại:\n{url}");
            }
        }

        private HtmlElement getData(string tag, string att, string attVal)
        {
            HtmlElementCollection elements = webBrowser1.Document.GetElementsByTagName(tag);
            foreach (HtmlElement element in elements)
            {
                if (element.GetAttribute(att).Equals(attVal))
                {
                    return element;
                }
            }
            return null;
        }
    }
}
