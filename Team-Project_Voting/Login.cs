using System;
using System.Linq;
using System.Windows.Forms;

namespace Team_Project_Voting
{
    public partial class Login : Form
    {
        ServerSpeaking server;
        public Login()
        {
            InitializeComponent();
             server = new ServerSpeaking();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            server.Login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var registerForm = new Register();
            registerForm.ShowDialog(this);
        }
    }
}
