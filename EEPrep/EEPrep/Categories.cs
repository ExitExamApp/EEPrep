using System;
using System.Collections;
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
    public partial class CategoryForm : Form
    {
        ArrayList Topics = new ArrayList();
        int questions;
        bool click = false;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            click = true;
            foreach(CheckBox CB in TopicGroupBox.Controls)
            {
               
                if(CB.Checked)
                {
                    Topics.Add(CB.Text);
                }
                
            }
            foreach(CheckBox question in randomGrpBx.Controls)
            {
                if (question.Checked)
                    questions = Convert.ToInt32(question.Tag);
            }

            this.Close();

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

            checkBox5.Checked = !checkBox9.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = !checkBox5.Checked;


        }
        public ArrayList GetTopics()
        {
            return Topics;
        }
        public int QNum ()
        {
            return questions;
 
        }
        public bool done()
        {
            return click;
        }

    }
}
