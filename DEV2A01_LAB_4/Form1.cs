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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnect register = new DatabaseConnect();
            login login = new login();

            register.Name = reg_password.Text;
            register.Email = reg_email.Text;

            if (reg_username.Text != "" && reg_password.Text != "" && reg_re_password.Text != "" && reg_email.Text != "")
            {
                if (reg_password.Text == reg_re_password.Text)
                {
                    register.reg_User(reg_username.Text, reg_password.Text, reg_re_password.Text, reg_email.Text);

                    this.Hide();
                    login = new login();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("fill up the blank spaces");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
