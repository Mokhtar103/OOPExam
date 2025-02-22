using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public abstract class Question
    {
        public abstract string? Header { get; }
        public string? Body { get; set; }

        public int Mark {  get; set; }

        public Answers[] AnswerList { get; set; }
        public Answers RightAnswer { get; set; }
        public Answers UserAnswer { get; set; }

       

        public Question()
        {
            
            RightAnswer = new Answers();
            UserAnswer = new Answers();
        }

        public abstract void AddQuestions();

        public override string ToString()
        {
            return $"-- {Header}\n{Mark} marks\n --{Body}";
        }
    }
}
