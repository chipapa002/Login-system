using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DEV2A01_LAB_4
{
    internal class DatabaseConnect
    {
        private static string connect = "Data Source = TSHIPAPA\\SQLEXPRESS; Initial Catalog = DEV_COMP; Integrated Security = True";
        public static SqlConnection connection = new SqlConnection(connect);
        public int logged = 0;
        public SqlDataAdapter adapter = null;
        public string Name { get; set; }
        public string Email { get; set; }



        public void reg_User(string username, string password, string re_password, string email)
        {
            try
            {
                SqlCommand command = new SqlCommand("Reg_Person", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Re_password", re_password);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int execute = command.ExecuteNonQuery();
                if (execute > 0)
                {
                    MessageBox.Show("Registration Successful!!!");
                }
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void retrieve(string username, string password)
        {
            try
            {
                connection.Open();
                string login = "SELECT * FROM REGISTRATION_TBL WHERE UserName = '" + username + "' AND Reg_Password = '" + password + "'";
                SqlCommand command = new SqlCommand(login, connection);
                SqlDataReader dataRead = command.ExecuteReader();

                if (dataRead.Read() == true)
                {
                    MessageBox.Show("Login Successful!!");
                    logged = 1;

                }
                else
                {
                    MessageBox.Show("incorrect Username or Password");
                }

                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public void user_apply(int ID_num, string f_name, string l_name, string phone_No, string gender, string course)
        {
            try
            {
                SqlCommand command = new SqlCommand("user_apply", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ID_num", ID_num);
                command.Parameters.AddWithValue("@f_name", f_name);
                command.Parameters.AddWithValue("@l_name", l_name);
                command.Parameters.AddWithValue("@phone_num", phone_No);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Course", course);

                connection.Open();
                int execute = command.ExecuteNonQuery();

                Console.WriteLine(execute);

                if (execute > 0)
                {
                    MessageBox.Show("Application Successful!!!");
                }
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        public SqlDataAdapter view()
        {
            connection.Open();
            string search = "SELECT * FROM appication";
            SqlCommand command = new SqlCommand(search, connection);
            adapter = new SqlDataAdapter(command);
            connection.Close();

            return adapter;


        }
        public string GetName()
        {

            string sql = "SELECT * FROM REGISTRATION_TBL";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader oReader = command.ExecuteReader();
            while (oReader.Read())
            {
                Name = oReader["UserName"].ToString();
            }
            connection.Close();
            return Name;
        }
        public string GetEmail()
        {

            string sql = "SELECT * FROM REGISTRATION_TBL";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader oReader = command.ExecuteReader();
            while (oReader.Read())
            {
               
                Email = oReader["Reg_Email"].ToString();
            }
            connection.Close();
            return Email;
        }

    }
}
