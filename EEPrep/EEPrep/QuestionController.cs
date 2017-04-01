using System;
using System.Collections.Generic;
using System.Data;

namespace EEPrep
{
    public class QuestionController
    {
        private IDbDataProvider provider;

        public QuestionController(IDbDataProvider provider)
        {
            this.provider = provider;
        }


        public IEnumerable<Question> GetQuestions()
        {
            IDataReader dataReader = provider.ExecuteReader("SELECT * FROM examdb.examprepques;");
            IEnumerable<Question> results = new List<Question>();
            while (dataReader.Read())
            {
                (results as List<Question>).Add(GetQuestion(dataReader));
            }
            return results;
        }

        private Question GetQuestion(IDataReader dataReader)
        {
            Question result = new Question();
            result.QuestionText = Convert.ToString(dataReader["Question"]);
            result.OptionA = Convert.ToString(dataReader["OptionA"]);
            result.OptionB = Convert.ToString(dataReader["OptionB"]);
            result.OptionC = Convert.ToString(dataReader["OptionC"]);
            result.OptionD = Convert.ToString(dataReader["OptionD"]);
            result.OptionE = Convert.ToString(dataReader["OptionE"]);
            result.Answer = Convert.ToChar(dataReader["CorrectAnswer"]);
            result.Reason = Convert.ToString(dataReader["Reason"]);
            return result;
        }
    }
}