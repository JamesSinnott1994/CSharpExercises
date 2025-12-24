using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class Stopwatch
    {
        // User starts StopWatch
        // Get time now

        // User stops StopWatch
        // Get end time, and duration between the two

        private DateTime _start;
        private DateTime _end;
        private TimeSpan _duration;
        public bool Started { get; set; } // Property


        public void Start() {
            _start = DateTime.Now;
            Started = true;
            Console.WriteLine("Stopwatch started \n");
        }

        public void Stop() {
            _end = DateTime.Now;
            _duration = _end - _start;
            Started = false;
            Console.WriteLine(_duration);
            Console.WriteLine("Stopwatch stopped \n");
        }
    }
}
