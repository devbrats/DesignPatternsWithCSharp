using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer_Pattern
{
    public class NoiseObserver
    {
        public NoiseObserver(NoiseAlarm alarm)
        {
            _noiseAlarm = alarm;
        }

        public void VerifyNoseLevel(int noiseLevel)
        {
            if (noiseLevel > 80)
            {
                Console.WriteLine("Observer One");
                _noiseAlarm.RaiseAlarm();
            }
        }

        private NoiseAlarm _noiseAlarm;
    }

    public class NoiseObserverTwo
    {
        public event Action RaiseAlarm;

        public void VerifyNoseLevel(int noiseLevel)
        {
            if (noiseLevel > 80)
            {
                Console.WriteLine("Observer Two");
                RaiseAlarm();
            }
        }
    }
}
