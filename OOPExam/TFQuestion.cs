using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class TFQuestion : Question
    {
        public override string? Header => "True | False Question";

        public TFQuestion()
        {
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");
        }

        public override void AddQuestions()
        {
            Console.WriteLine(Header);

            do
            {
                Console.WriteLine("Please Enter The Body Of Question: ");
                Body = Console.ReadLine();
            } while (Body is null);

            int marks;

            do
            {
                Console.WriteLine("Please Enter The Marks of Question: ");

            }
            while (!(int.TryParse(Console.ReadLine(), out marks) && marks > 0));

            Mark = marks;

            int rightAnswer;

            do
            {
                Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for false): ");

            } while ( !(int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer == 1 || rightAnswer == 2)) );
            RightAnswer.Id = rightAnswer;
            RightAnswer.Text = AnswerList[rightAnswer - 1].Text;
            Console.Clear();
        }
    }
}
