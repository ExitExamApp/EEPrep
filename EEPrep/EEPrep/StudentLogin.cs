using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class StudentLoginForm : Form
    {

        //Variable Declarations
        bool login = false;


        public StudentLoginForm()
        {
        
            InitializeComponent();
        }

        private void StuLoginNextButton_Click(object sender, EventArgs e)
        {
            login = true;
            this.Close();
        }
        public string GetName()
        {
            return NameTextBox.Text;
        }
        public string GetEmail()
        {
            return EmailTextBox.Text + domainTextBox.Text;
        }
        public bool showcat()
        {
            return login;
        }
    }
}
