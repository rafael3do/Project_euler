using System;
using System.Linq;

namespace ProjectEuler
{
    class Problem10
    {
        /// <summary>
        /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        /// Find the sum of all the primes below two million.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string [] args)
        {
            long sum=2;
            bool isPrime = true;
            for (int i = 3; i < 2000000; i++)
            {
                double aa = Math.Sqrt((double)i);
                for (int j = 2; j <= aa; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += i;
                }
                isPrime = true;
            }
            Console.WriteLine("Sum  = " + sum);

            Console.ReadKey();
        }
    }
}
