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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mainPage = new Form1();
            mainPage.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            DatabaseConnect login = new DatabaseConnect();

            login.retrieve(Username.Text, Password.Text);
            

            if (login.logged == 1)
            {
                this.Hide();
                logged_in inside = new logged_in();
                inside.ShowDialog();
            }
            else
            {
                Username.Clear();
                Password.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
