using Microsoft.Identity.Client;
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
        public string GetLogin()
        {
            return logon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var registerForm = new Register();
            registerForm.ShowDialog(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
