using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EEPrep
{
    public partial class WelcomingScreen : Form 
    {
        private readonly QuestionController _questionController;
        Student stud = new Student();
        int NumOfQ = 0;
        public WelcomingScreen()
        {

            InitializeComponent();
            this.IsMdiContainer = false;
       //     MySqlDatabaseConnection db = new MySqlDatabaseConnection("EEPrep.DatabaseConnection");
       //     MySqlDataProvider provider = new MySqlDataProvider(db);
      //      _questionController = new QuestionController(provider);

        }

        public QuestionController QuestionController
        {
            get { return _questionController; }
        }

        private void WelcomingScreen_Load(object sender, EventArgs e)
        {
            // call to get the questions from the db so this is the first time the program connects
            // to the database
          //  IEnumerable<Question> questions = QuestionController.GetQuestions();
         //   foreach (Question question in questions)
            {
        //        String value = question.QuestionText;
       //         Console.WriteLine(value);
            }
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            string A = "";
            this.Hide();
            CategoryForm options = new CategoryForm();
            using (StudentLoginForm StudentLogin = new StudentLoginForm())
            {
                StudentLogin.ShowDialog();
                if(StudentLogin.showcat())
                {
                    stud.Email = StudentLogin.GetEmail();
                    stud.Name = StudentLogin.GetName();
                    options.ShowDialog();
                    if(options.done())
                    {
                        options.Close();
                        stud.setTopics(options.GetTopics());
                        NumOfQ = options.QNum();
                    }
                    foreach (var s in options.GetTopics() )
                    {
                        A += s.ToString();

                    }
                        MessageBox.Show(stud.Name + stud.Email +  A + NumOfQ.ToString());

                }
            }
                
        }

       
        private void aboutButton_Click(object sender, EventArgs e)
        {
            About_Screen about = new About_Screen();
            about.ShowDialog();
        }
    }
}
