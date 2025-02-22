using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class PracticalExam : Exam
    {

        public PracticalExam(int time, int numOfQuestions):base(time, numOfQuestions)
        {
            
        }
        public override void CreateQuestions()
        {
            Questions = new MCQQuestion[NumberOfQuestions];

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i] = new MCQQuestion();
                Questions[i].AddQuestions();
            }
            Console.Clear();
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
                Console.WriteLine("-----------------------------");
                int userAnswer;

                do
                {
                    Console.WriteLine("Please Enter The Right Answer for the Question: ");
                }
                while ( !(int.TryParse(Console.ReadLine(), out userAnswer) && (userAnswer == 1 || userAnswer == 2 || userAnswer == 3)));

                question.UserAnswer.Id = userAnswer;
                question.UserAnswer.Text = question.AnswerList[userAnswer - 1].Text;
            }
            Console.Clear();
            Console.WriteLine("Right Answers For Practical Exam: ");

            for(int i = 0;i < Questions?.Length;i++)
            {
                Console.WriteLine($"{i + 1} : {Questions[i].Body}");
                Console.WriteLine($"Right Answer => {Questions[i].RightAnswer.Text}");
                Console.WriteLine("-------------------------------------");

            }
        }
    }
}
