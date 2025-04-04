using System;

namespace Recursie.library
{
    public class Teller
    {
        public static void UpCounter(int number)
        {
            // throw new NotImplementedException();
            if (number < 0)
            {
                throw new ArgumentException("number can not be negative");
            }

            if (number == 0)
            {
                return;
            }

            UpCounter(number - 1);
            Console.WriteLine(number);
        }
    }
}
