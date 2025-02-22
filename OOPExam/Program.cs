using System.Diagnostics;

namespace OOPExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Subject subj1 = new Subject(1, "C#");
            subj1.CreateExam();
            Console.Clear();

            char userChoice;
            do
            {
                Console.WriteLine("Please enter Y to Start exam | N to exit");
            }
            while (!(char.TryParse(Console.ReadLine(), out userChoice) && (userChoice == 'Y' || userChoice == 'y' || userChoice == 'N' || userChoice == 'n')));

            if(userChoice == 'y' || userChoice == 'Y')
            {
                Console.Clear();
                Stopwatch sw = new Stopwatch();
                sw.Start();
                subj1.SubjectExam.DisplayExam();
                sw.Stop();
                Console.WriteLine($"You Take {sw.Elapsed} to solve the exam");
            }
        }
    }
}
