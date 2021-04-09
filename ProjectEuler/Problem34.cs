using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem34
    {
        /// <summary>
        /// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        ///Find the sum of all numbers which are equal to the sum of the factorial of their digits.        
        ///Note: As 1! = 1 and 2! = 2 are not sums they are not included.
        /// </summary>
        
        static void Main (string [] agrs)
        {

            int result = 0;
            for (int i = 10; i < 2540161; i++)
            {
                int sumOfFacts = 0;
                int number = i;
                while (number > 0)
                {
                    int d = number % 10;
                    number /= 10;
                    sumOfFacts += factorial(d);
                }

                if (sumOfFacts == i)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
            Console.ReadKey();

        }
        static int factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            int y = x;
            for (int i = 1; i < x; i++)
            {
                y *= i;
            }

            return y;
        }
    }
}
