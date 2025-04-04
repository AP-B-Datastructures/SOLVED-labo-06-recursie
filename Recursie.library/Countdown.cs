using System;

namespace Recursie.library
{
    public class Countdown
    {
        public static void StartCountdown(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("negative values not allowed");
            }

            if (number == 0)
            {
                Console.WriteLine("Takeoff");
                return;
            }

            Console.WriteLine(number);
            StartCountdown(number - 1);
        }
    }
}
