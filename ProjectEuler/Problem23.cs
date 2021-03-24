using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem23
    {
        /// <summary>
        /// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. For example, the sum of 
        /// the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
        ///A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
        ///As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers 
        ///is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
        ///However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed
        ///as the sum of two abundant numbers is less than this limit.
        ///Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
        /// 
        /// NOTE: waint six minuts from print result (averange)
        /// </summary>


        static void Main (string [] args)
        {
            int limit = 28123;
            ArrayList array = new ArrayList();
            ArrayList abundant_array = new ArrayList();

            for (int j = 2; j <= limit; j++)
            {
                int i = 2;
                while (i < j)
                {
                    int division = j / i;
                    if (j % i == 0)
                        array.Add(division);
                    i++;
                }
                int sum = 0;
                for (int k = 0; k < array.Count; k++)
                    sum += (int)array[k];

                if (sum > j)
                    abundant_array.Add(j);

                array.Clear();
            }

            ArrayList abundant_sum_array = new ArrayList();

            for (int i = 0; i < abundant_array.Count; i++)
            {
                for (int j = 0; j < abundant_array.Count; j++)
                {
                    if (Convert.ToInt32(abundant_array[i]) + Convert.ToInt32(abundant_array[j]) <= limit)
                    {
                        abundant_sum_array.Add(Convert.ToInt32(abundant_array[i]) + Convert.ToInt32(abundant_array[j])); // arraylist member'lari icin toplama
                    }
                }
            }

            ArrayList result = new ArrayList();

            for (int i = 0; i <= limit; i++)
            {
                if (!abundant_sum_array.Contains(i))
                {
                    result.Add(i);
                }
            }

            UInt32 result_sum = 0;

            for (int i = 0; i < result.Count; i++)
            {
                result_sum += Convert.ToUInt32(result[i]);
            }

            Console.WriteLine(result_sum);
            Console.ReadKey();
        }
    }
}
