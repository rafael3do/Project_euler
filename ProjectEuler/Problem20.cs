using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    ///For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    ///and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    ///Find the sum of the digits in the number 100!
    /// </summary>
    class Problem20
    {
        static void Main (string [] args)
        {
            int sum = 0;
            BigInteger fac = 1;

            for (int i = 2; i <= 100; i++)
            {
                fac *= i;
            }

            while (fac > 0)
            {
                sum += (int)(fac % 10);
                fac /= 10;
            }
            Console.WriteLine(sum.ToString());
            Console.ReadKey();
        }
    }
}
