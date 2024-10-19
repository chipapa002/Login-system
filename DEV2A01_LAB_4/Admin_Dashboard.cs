using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV2A01_LAB_4
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
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

        }

        private void view_Click(object sender, EventArgs e)
        {
            DatabaseConnect view = new DatabaseConnect();

            view.adapter = view.view();

            DataTable table = new DataTable();

            view.adapter.Fill(table);

            AdminView.DataSource = table;
        }
    }
}
