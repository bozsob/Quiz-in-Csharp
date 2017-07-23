using System;

namespace Demo_quiz
{
    internal class CurrentTime
    {
        public delegate void TimeChangedEventHandler(object sender, EventArgs e);

        public event TimeChangedEventHandler TimeChanged;

        public void DisplayTime()
        {
            Console.WriteLine("Display the current date in every 2 seconds..\n");

            OnTimeChanged();
        }

        protected virtual void OnTimeChanged()
        {
            if (TimeChanged != null)
            {
                TimeChanged(this, EventArgs.Empty);
            }
        }
    }
}