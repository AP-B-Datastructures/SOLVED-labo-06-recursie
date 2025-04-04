using System;

namespace Recursie.library
{
    public class Faculteit
    {
        public static int BerekenFaculteit(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number can not be negative");
            }
            
            // throw new NotImplementedException();
            if (number == 0)
            {
                return 1;
            }

            return number * BerekenFaculteit(number - 1);
        }
    }
}
