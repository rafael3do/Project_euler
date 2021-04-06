using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem32
    {
        /// <summary>
        /// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        /// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
        /// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        /// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
        /// </summary>

        static void Main(string[] args)
        {
            List<long> products = new List<long>();
            long sum = 0;
            long prod, compiled;

            for (long m = 2; m < 100; m++)
            {
                long nbegin = (m > 9) ? 123 : 1234;
                long nend = 10000 / m + 1;

                for (long n = nbegin; n < nend; n++)
                {
                    prod = m * n;
                    compiled = concat(concat(prod, n), m);
                    if (compiled >= 1E8 && compiled < 1E9 && isPandigital(compiled))
                    {
                        if (!products.Contains(prod))
                        {
                            products.Add(prod);
                        }
                    }
                }
            }

            for (int i = 0; i < products.Count; i++)
            {
                sum += products[i];
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }



        static long concat(long a, long b)
        {
            long c = b;
            while (c > 0)
            {
                a *= 10;
                c /= 10;
            }
            return a + b;
        }

        static bool isPandigital(long n)
        {
            int digits = 0;
            int count = 0;
            int tmp;

            while (n > 0)
            {
                tmp = digits;
                digits = digits | 1 << (int)((n % 10) - 1); //The minus one is there to make 1 fill the first bit and so on
                if (tmp == digits)
                { //Check to see if the same digit is found multiple times
                    return false;
                }
                count++;
                n /= 10;
            }
            return digits == (1 << count) - 1;
        }
    }
}
