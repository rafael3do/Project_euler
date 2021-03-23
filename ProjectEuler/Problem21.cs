using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem21
    {
        /// <summary>
        /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        ///If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
        ///For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
        ///The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
        ///Evaluate the sum of all the amicable numbers under 10000.
        /// </summary>


        static void Main(string[] args)
        {
            long sum = 0;
            List<int> passedValues = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                var number1 = SumOfNumber(i);
                var number2 = SumOfNumber(SumOfNumber(i));


                if (number2 == i && i < number1)
                {
                    sum = sum + i + number1;

                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        private static int SumOfNumber(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input / 2; i++)
            {
                if (input % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }

}
