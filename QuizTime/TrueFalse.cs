using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class TrueFalse : Question
    {

        private List<string> possibleAnswers = new List<string>();
        
        public TrueFalse(string question)
        {
            QuestionBody = question;
            possibleAnswers.Add("True");
            possibleAnswers.Add("False");
        }

        public override List<string> PossibleAnswers {
            get { return possibleAnswers; }
            internal set { value = possibleAnswers; }
        }
    }
}
