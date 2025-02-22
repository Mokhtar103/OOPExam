using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class FinalExam : Exam
    {

        public FinalExam(int time, int numOfQuestions):base(time, numOfQuestions) { }

        public override void CreateQuestions()
        {
            Questions = new Question[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                int choice;

                do
                {
                    Console.WriteLine("Please Enter the type of exam you want to create (1 for MCQ and 2 for TF): ");
                }
                while ( !(int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2) ) );
                Console.WriteLine();

                if( choice == 1 )
                {
                    Questions[i] = new MCQQuestion();
                    Questions[i].AddQuestions();
                }
                else
                {
                    Questions[i] = new TFQuestion();
                    Questions[i].AddQuestions();
                }
            }
        }

        public override void DisplayExam()
        {
            foreach (var question in Questions)
            {
                Console.WriteLine(question);
                for (int i = 0; i < question.AnswerList.Length; i++)
                {
                    Console.WriteLine(question.AnswerList[i]);
                }
                int userAnswer;

                if (question.GetType() == typeof(MCQQuestion))
                {
                    do
                    {
                        Console.WriteLine("Please Enter The Right Answer for the Question: ");
                    }
                    while ( !(int.TryParse(Console.ReadLine(), out userAnswer) && (userAnswer == 1 || userAnswer == 2 || userAnswer == 3)) );
                }
                else
                {
                    do
                    {
                        Console.WriteLine("Please Enter The Right Answer of Question (1 for True and 2 for false): ");

                    } while (!(int.TryParse(Console.ReadLine(), out userAnswer) && (userAnswer == 1 || userAnswer == 2)));
                }
                question.UserAnswer.Id = userAnswer;
                question.UserAnswer.Text = question.AnswerList[userAnswer - 1].Text;
                
            }

            Console.Clear();

            int grade = 0, totalMarks = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                totalMarks += Questions[i].Mark;
                if (Questions[i].UserAnswer.Id == Questions[i].RightAnswer.Id)
                {
                    grade += Questions[i].Mark;
                }

                Console.WriteLine($"{i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Your Answer => {Questions[i].UserAnswer.Text}");
                Console.WriteLine($"The Right Answer => {Questions[i].RightAnswer.Text}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine($"Your Exam Grade is {grade} out of {totalMarks}");
        }
    }
}
