using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Question
    {

        public string QuestionBody { get; set; }

        public string Answer { get; set; }

        public virtual List<string> PossibleAnswers { get; internal set; }

    }
}
