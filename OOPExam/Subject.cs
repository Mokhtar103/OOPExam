using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam SubjectExam { get; set; }

        public Subject() { }

        public Subject(int _id, string _name)
        {
            this.Id = _id;
            this.Name = _name;
        }

        public void CreateExam()
        {
            int typeOfExam, time, NumOfQuestions;

            do
            {
                Console.WriteLine("Enter the type of exam you want to create [1 For Practical / 2 For Final]: ");
            }
            while ( !(int.TryParse(Console.ReadLine(), out typeOfExam) && (typeOfExam == 1 || typeOfExam == 2)) );

            do
            {
                Console.WriteLine("Please Enter The Time Of Exam In Minutes: ");
            }
            while ( !(int.TryParse(Console.ReadLine(), out time) && (time > 0)) );

            do
            {
                Console.WriteLine("Please Enter The Number Of Questions You want to create:  ");
            }
            while (!(int.TryParse(Console.ReadLine(), out NumOfQuestions) && (NumOfQuestions > 0)) );

            if(typeOfExam == 1)
            {
                SubjectExam = new PracticalExam(time, NumOfQuestions);
            }
            else
            {
                SubjectExam = new FinalExam(time, NumOfQuestions);
            }

            Console.Clear();
            SubjectExam.CreateQuestions();


        }
    }
}
