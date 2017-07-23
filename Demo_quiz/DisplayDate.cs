using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_quiz
{
    class DisplayDate
    {

        public void OnTimeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Current date: " + DateTime.Now + "\n");
        }
    }
}
