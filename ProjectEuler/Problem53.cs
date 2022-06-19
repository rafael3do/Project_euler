using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem53
    {
        /// <summary>
        /// There are exactly ten ways of selecting three from five, 12345:
        ///123, 124, 125, 134, 135, 145, 234, 235, 245, and 345
        ///In combinatorics, we use the notation, .In general,, where, , and .
        ///It is not until, that a value exceeds one-million: .
        ///How many, not necessarily distinct, values of 
        /// for , are greater than one-million?
        /// </summary>
        /// <param name="args"></param>
        static void Main (string [] args)
        {
            int result = 0;
            const int limit = 1000000;
            const int nlimit = 100;

            for (int n = 1; n <= nlimit; n++)
            {
                for (int r = 0; r <= n; r++)
                {
                    if (factorial(n) / (factorial(r) * factorial(n - r)) >= limit) result++;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();
             BigInteger factorial(int x)
            {
                BigInteger y = 1;
                for (int i = 2; i <= x; i++)
                {
                    y *= i;
                }
                return y;
            }

             BigInteger[] factorials(int x)
            {
                if (x < 0) return null;

                BigInteger[] y = new BigInteger[x + 1];
                y[0] = 1;

                for (int i = 1; i <= x; i++)
                {
                    y[i] = y[i - 1] * i;
                }

                return y;
            }
        }
       

    }
}

