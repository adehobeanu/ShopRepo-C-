using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private bool started;
        private List<TimeSpan> times;

        public StopWatch()
        {
            times = new List<TimeSpan>();
            started = false;


        }

        public void Start() 
        {
            if (!started)
            {
                started = true;
                startTime = DateTime.Now;
                Console.WriteLine("StopWatch started");
            } else
            {
                Console.WriteLine("StopWatch is already started");
            }
        }

        public void Stop()
        {
            TimeSpan time = DateTime.Now - startTime;
            string timeStr = time.ToString(@"hh\:mm\:ss");
            times.Add(time);
            Console.WriteLine("StopWatch stoped");
            Console.WriteLine($"Time is: {timeStr}");
        }
    }
}
