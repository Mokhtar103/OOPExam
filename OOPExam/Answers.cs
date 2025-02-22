using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam
{
    public class Answers
    {
        public int Id {  get; set; }
        public string? Text { get; set; }

        public Answers() { }

        public Answers(int _id, string _text)
        {
            this.Id = _id;
            this.Text = _text;
        }

        public override string ToString()
        {
            return $"{Id}) {Text}";
        }
    }
}
