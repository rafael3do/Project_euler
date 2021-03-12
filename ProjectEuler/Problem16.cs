using System;
using System.Numerics;

/// <summary>
/// 215 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
/// What is the sum of the digits of the number 21000?
/// </summary>

namespace ProjectEuler
{
    class Problem16
    {
        static void Main (string []args)
        {
            int result = 0;
            BigInteger number = BigInteger.Pow(2, 1000);
            while (number > 0)
            {
                result += (int)(number % 10);
                number /= 10;
            }

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
