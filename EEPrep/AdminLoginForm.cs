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
    public partial class AdminLoginForm : Form
    {
        //Variable Declarations
        bool login;

        public AdminLoginForm()
        {
            InitializeComponent();
        }

        public bool successLogin()
        {
            return login;
        }
    }
}
