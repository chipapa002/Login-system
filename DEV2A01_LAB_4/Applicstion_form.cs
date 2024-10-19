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
    public partial class Application_form : Form
    {
        public Application_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "USER PROFILE";

            this.Hide();
            logged_in profile = new logged_in();
            profile.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "ADMIN DASHBOARD";

            this.Hide();
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleIdentifier.Text = "";
            TitleIdentifier.Text += "APPLICATION FORM";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DatabaseConnect apply = new DatabaseConnect();
            string gender = "female";
            int ID = 0;
             

            if(ID_Num.Text != "" && First_Name.Text != "" && Last_Name.Text != "" && Phone_Num.Text != "" && male.Checked == true || female.Checked == true && Courses.Text != "")
            {
                if (male.Checked)
                {
                    gender = "male";
                    apply.user_apply(ID = int.Parse(ID_Num.Text), First_Name.Text, Last_Name.Text, Phone_Num.Text, gender, Courses.Text);
                }
                else
                {
                    apply.user_apply(ID = int.Parse(ID_Num.Text), First_Name.Text, Last_Name.Text, Phone_Num.Text, gender, Courses.Text);
                }
            }
            else
            {
                MessageBox.Show("fill up the blank spaces");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ID_Num.Clear();
            First_Name.Clear();
            Last_Name.Clear();
            Phone_Num.Clear();
            male.Checked = false;
            female.Checked = false;
            Courses.Text = "";
        }
    }
}
