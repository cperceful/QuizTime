using System;

namespace QuizTime
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueFalse q = new TrueFalse("Cameron is great");

            Console.WriteLine(q.QuestionBody);
            foreach (string i in q.PossibleAnswers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}