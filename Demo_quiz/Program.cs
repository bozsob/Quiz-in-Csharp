using System.Threading;

namespace Demo_quiz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CurrentTime ct = new CurrentTime();
            DisplayDate dd = new DisplayDate();
            ct.TimeChanged += dd.OnTimeChanged;

            for (int i = 0; i < 10; i++)
            {
                ct.DisplayTime();
                Thread.Sleep(2000);
            }
        }
    }
}