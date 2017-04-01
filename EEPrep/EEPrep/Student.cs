using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEPrep
{
    public class Student
    {
        private string email { set; get; }
        private string name { set; get; }
        private int numQuestionsCorrect { set; get; }
        private int numQuestionsAttempt { set; get; }
        private ArrayList topics { set; get; }
    }
}
