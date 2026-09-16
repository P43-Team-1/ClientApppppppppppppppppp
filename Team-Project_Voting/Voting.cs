using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team_Project_Voting
{
    public partial class Voting : Form
    {
        public Voting()
        {
            InitializeComponent();
            label1.Size = new Size(400, 20);
        }

        private void Voting_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome to the Voting System!\nI think this is a great idea!" +
    "\nMebombo\n and I'm excited to participate!\n Kommmmmmmmbo";
        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            int paddingBottom = 10;

            this.Height = label1.Bottom + paddingBottom;

            flowLayoutPanel1.Top += label1.Bottom;
        }
    }
}
