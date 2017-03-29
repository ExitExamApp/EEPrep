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

namespace EEPrep
{
    public partial class AdminLoginForm : Form
    {
        //Variable Declarations
        bool login;
        private string username;
        private string password;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        public bool successLogin()
        {
            return login;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=104.131.28.50/phpmyadmin; " +
                                    "Initial Catalog=Exam_Questions;User ID=admin;Password=arc3";

           
            username = unameTextbox.Text;
            password = pWordTextbox.Text;

            string queryString = "SELECT* FROM Administration WHERE Username = ' " + unameTextbox.Text + " ' and " +
                                            " Password = '" + pWordTextbox + "'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                    }
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }
        }

        private void validateSignIn()
        {
            
        }
    }
}
