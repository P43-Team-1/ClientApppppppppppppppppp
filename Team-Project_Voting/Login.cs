using Microsoft.Identity.Client;
using System;
using System.Linq;
using System.Windows.Forms;
using Team_Project_Voting.Data;
namespace Team_Project_Voting
{
    public partial class Login : Form
    {
        public string logon;
        public Login()
        {
            InitializeComponent();
            ControlBox = false;
            //FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            using (var context = new VotingMenu())
            {

                var user = context.Users
                    .FirstOrDefault(x => x.Login == login && x.Password == password);
                logon = user.Login;
                
                if (user != null)
                {
                    MessageBox.Show("Ви успішно увійшли");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильний логін або пароль");
                }

            }
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
