using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem36
    {
        /// <summary>
        /// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
        ///Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        ///(Please note that the palindromic number, in either base, may not include leading zeros.)
        /// </summary>

        static void Main(string[] args)
        {
            const int limit = 1000000;
            int result = 0;

            for (int i = 1; i < limit; i += 2)
            {
                if (IsPalindrome(i, 10) && IsPalindrome(i, 2))
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static bool IsPalindrome(int number, int b)
        {
            int reversed = 0;
            int k = number;

            while (k > 0)
            {
                reversed = b * reversed + k % b;
                k /= b;
            }
            return number == reversed;
        }
    }
}
