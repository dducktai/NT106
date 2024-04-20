using Lab2;

namespace Lab_2
{
    public partial class formLab2 : Form
    {
        public formLab2()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Task1 b1 = new Task1();
            this.Hide();
            b1.ShowDialog();
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Task2 b2 = new Task2();
            this.Hide();
            b2.ShowDialog();
            this.Show();
        }


        private void formLab2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Task3 b3 = new Task3();
            this.Hide();
            b3.ShowDialog();
            this.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Task5 t5 = new Task5();
            this.Hide();
            t5.ShowDialog();
            this.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Task4 t4 = new Task4();
            this.Hide();
            t4.ShowDialog();
            this.Show();
        }
    }
}
