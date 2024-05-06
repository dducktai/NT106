namespace Lab3
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        Task1_Client client;
        Task1_Server server;

        private void btnClient_Click(object sender, EventArgs e)
        {
            client = new Task1_Client();
            client.Show();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            server = new Task1_Server();
            server.Show();
        }

        private void Task1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
