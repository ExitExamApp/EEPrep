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
        private string email;
        private string name;
        private int numQuestionsCorrect;
        private int numQuestionsAttempt;
        private ArrayList topics;
        public Student()
        {
            Email = Name = "";
            Questions_Correct = Questions_Attempted = 0;
            topics = new ArrayList();
        }
        public string Email
        {
            get
            {
                return email ;
            }

            set
            {
                 email = value;
            }
        }
        public string Name 
        {
            get
            {
                return name ;
            }

            set
            {
                name = value;
            }
        }
            public int Questions_Correct
        {
            get
            {
                return numQuestionsCorrect;
            }

            set
            {
                numQuestionsCorrect = value;
            }
        }
            public int Questions_Attempted
        {
            get
            {
                return numQuestionsAttempt;
            }

            set
            {
                numQuestionsAttempt = value;
            }
        }
        public void  setTopics(ArrayList listoftopics)
        {
            topics.AddRange(listoftopics);
        }
    }
}
