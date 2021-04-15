using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem38
    {
        /// <summary>
        /// Take the number 192 and multiply it by each of 1, 2, and 3:
        ///192 × 1 = 192
        ///192 × 2 = 384
        ///192 × 3 = 576
        /// By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and(1,2,3)
        /// The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the 
        /// concatenated product of 9 and(1,2,3,4,5).
        /// What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with(1,2, ... , n) 
        /// where n > 1?
        /// </summary>
       
        static void Main(string[] args)
        {
            long result = 0;
            for (long i = 9387; i >= 9234; i--)
            {
                result = concat(i, 2 * i);
                if (isPandigital(result))
                {
                    break;
                }
            }           
            Console.WriteLine(result);
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
