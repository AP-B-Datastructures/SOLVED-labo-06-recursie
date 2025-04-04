using System;

namespace Recursie.library
{
    public class Fibonacci
    {
        public static int FibonacciNr(int n)
        {
            if (n < 0)
                throw new ArgumentException();

            if (n <= 2)
                return n - 1;
            return FibonacciNr(n - 1) + FibonacciNr(n - 2);
        }

        public static string FibonacciSerie(int count)
        {
            var result = "";
            if (count <= 0)
                return result;

            if (count > 1)
                result += "-";
                
            if (count <= 2)
                result += $"{count - 1}";
            else
                result += $"{FibonacciNr(count - 1) + FibonacciNr(count - 2)}";


            return FibonacciSerie(count - 1) + result;
        }
    }
}
