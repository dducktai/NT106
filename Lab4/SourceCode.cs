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
    public partial class SourceCode : Form
    {
        public SourceCode(string url)
        {
            InitializeComponent();
            try
            {
                rtbSource.Text = getHTML(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public SourceCode(string source) : this()
        //{
        //    rtbSource.Text = source;
        //}
        private string getHTML(string szUrl)
        {
            
            WebRequest request = WebRequest.Create(szUrl);
           
            WebResponse response = request.GetResponse();
           
            Stream dataStream = response.GetResponseStream();
        
            StreamReader reader = new StreamReader(dataStream);
      
            string responseFromServer = reader.ReadToEnd();
    
            response.Close();
            return responseFromServer;
        }
    }
}
