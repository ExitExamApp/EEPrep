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
        bool login;

        public StudentLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool successLogin()
        {
            return login;
        }
    }
}
