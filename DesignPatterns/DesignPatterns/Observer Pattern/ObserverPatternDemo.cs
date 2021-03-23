using System;

namespace DesignPatterns.Observer_Pattern
{
    public class ObserverPatternDemo : DesignPatternDemo
    {
        public override void Show()
        {
            Console.WriteLine("***Observer Pattern Demo***");
            Console.WriteLine("Raising Noise alarm if noise level goes beyond 80dB.");
            var noiseAlarm = new NoiseAlarm();

            // Type 1: Registering for raising alaram is hidden in observer.
            _noiseObserver = new NoiseObserver(noiseAlarm);

            // Type 2: Registering event outside the observer.
            _noiseObserverTwo = new NoiseObserverTwo();
            _noiseObserverTwo.RaiseAlarm += noiseAlarm.RaiseAlarm;

            SimulateNoiseLevelVariantion();
        }

        private void SimulateNoiseLevelVariantion()
        {
            Console.WriteLine("Press 'i' to increase and 'd' to decrease noise level by 10.");
            while (true)
            {
                var choice = Console.ReadKey();
                if (choice.KeyChar == 'i')
                {
                    noiseLevel += 10;
                }
                else if (choice.KeyChar == 'd')
                {
                    noiseLevel -= 10;
                }
                else
                {
                    break;
                }

                Console.WriteLine("\nNoise Level : " + noiseLevel);
                _noiseObserver?.VerifyNoseLevel(noiseLevel);
                _noiseObserverTwo?.VerifyNoseLevel(noiseLevel);
            }
           
        }

        int noiseLevel = 0;
        private NoiseObserver _noiseObserver ;
        private NoiseObserverTwo _noiseObserverTwo;
    }
}
