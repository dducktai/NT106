namespace Lab3
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Task1_Client client = new Task1_Client();
            client.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            Task1_Server server = new Task1_Server();
            server.Show();
        }
    }
}
