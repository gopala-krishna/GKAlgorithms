using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Problems
{
    class ClockAngle
    {
        public void HMClockAngle(int hour, int min)
        {
            hour = hour % 12; min = min % 60;

            Console.WriteLine(hour); Console.WriteLine(min);

            double angle = ((0.5) * ((60 * hour)+ min)) - (6 * min);

            Console.WriteLine(Math.Abs(angle));

        }
    }
}
