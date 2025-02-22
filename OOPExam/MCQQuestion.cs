using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class MCQQuestion : Question
    {
        public override string? Header => "Choose One Answer Question";

        public MCQQuestion()
        {
            AnswerList = new Answers[3];
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

            Console.WriteLine("The Choices of Questions: ");
            for (int i = 0; i < AnswerList?.Length; i++)
            {
                AnswerList[i] = new Answers() { Id = i + 1 };

                do
                {
                    Console.Write($"Enter the choice number {i + 1}: ");
                    AnswerList[i].Text = Console.ReadLine();
                }
                while (AnswerList[i].Text is null);
            }

            int rightAnswer;

            do
            {
                Console.WriteLine("Please Specify The Right Choice of Question:  ");

            } while (!(int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer == 1 || rightAnswer == 2 || rightAnswer == 3)));
            RightAnswer.Id = rightAnswer;
            RightAnswer.Text = AnswerList[rightAnswer - 1].Text;
            Console.Clear();
        }
    }
}
