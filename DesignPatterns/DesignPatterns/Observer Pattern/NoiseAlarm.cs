using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer_Pattern
{
    public class NoiseAlarm
    {
        public void RaiseAlarm()
        {
            Console.WriteLine("Noise level is high.");
        }
    }
}
