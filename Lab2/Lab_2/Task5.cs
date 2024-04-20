using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listViewFile.Items.Clear();
            FolderBrowserDialog opf = new FolderBrowserDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {

                string[] pathList = Directory.GetFiles(opf.SelectedPath, "*", SearchOption.AllDirectories);
                List<FileInfo> ListFileInfo = new List<FileInfo>();

                foreach (string item in pathList)
                {
                    ListFileInfo.Add(new FileInfo(item));
                }


                foreach (FileInfo fi in ListFileInfo)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = fi.Name
                    };
                    listViewFile.Items.Add(item);

                    ListViewItem.ListViewSubItem kichthuoc = new ListViewItem.ListViewSubItem(item, ((fi.Length)).ToString());
                    ListViewItem.ListViewSubItem DuoiMoRong = new ListViewItem.ListViewSubItem(item, ((fi.Extension)).ToString());
                    ListViewItem.ListViewSubItem NgayTao = new ListViewItem.ListViewSubItem(item, ((fi.CreationTime)).ToString());
                    item.SubItems.Add(kichthuoc);
                    item.SubItems.Add(DuoiMoRong);
                    item.SubItems.Add(NgayTao);

                }

            }
        }

    }
}
