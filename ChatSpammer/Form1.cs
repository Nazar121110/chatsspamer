using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSpammer
{
    public partial class MainHub : Form
    {
        public MainHub()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void LoginGradientButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(SpamBox1.Text);
            SendKeys.Send("{Enter}");

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/Preciselydev/");
        }
    }
}
