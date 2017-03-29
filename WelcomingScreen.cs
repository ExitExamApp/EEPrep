using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public partial class WelcomingScreen : Form 
    {
        public WelcomingScreen()
        {
            InitializeComponent();
        }

        private void WelcomingScreen_Load(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
        } 

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentLoginForm StudentLogin = new StudentLoginForm();
            StudentLogin.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminLoginForm AdminLogin = new AdminLoginForm();
            AdminLogin.Show();
        }

       
    }
}
