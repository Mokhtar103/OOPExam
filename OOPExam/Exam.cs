using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public abstract class Exam
    {
        public int Time {  get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam()
        {
            
        }

        public Exam(int _time, int _numOfQuestions)
        {
            this.Time = _time;
            this.NumberOfQuestions = _numOfQuestions;
        }

        public abstract void DisplayExam();

        public abstract void CreateQuestions();
    }
}
