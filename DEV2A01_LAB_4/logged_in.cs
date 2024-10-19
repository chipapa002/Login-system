using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV2A01_LAB_4
{
    public partial class logged_in : Form 
    {
        public string name;
        public string email;
        public logged_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "USER PROFILE";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "APPLICATION FORM";

            this.Hide();
            Application_form apply = new Application_form();
            apply.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "ADMIN DASHBOARD";

            this.Hide();
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleIdentifier_Click(object sender, EventArgs e)
        {

        }

        private void WELCOME_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DatabaseConnect log = new DatabaseConnect();

            email = log.GetEmail();
            name = log.GetName();

            WELCOME.Text = "Welcome " + name;
            Email.Text = "Email Address: " + email;
            label1.Text = "Application Status: No Application Details";
            message.Text = "";
            linkLabel1.Text = ""; 

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
