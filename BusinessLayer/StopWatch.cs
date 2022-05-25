using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StopWatch
    {
        private DateTime StartTime;
        private DateTime EndTime;
        private bool Running = false;

        // Start timer
        public void Start()
        {
            if(Running) 
                throw new InvalidOperationException("Stopwatch already started");

            StartTime = DateTime.Now;
            Running = true;
        }

        // Stop timer
        public void Stop()
        {
            if (!Running) 
                throw new InvalidOperationException("Stopwatch already stopped");

            EndTime = DateTime.Now;
            Running = false;
        }

        // Difference
        public TimeSpan GetDuration()
        {
            return EndTime - StartTime;
        }
    }
}
