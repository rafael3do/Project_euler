using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem43
    {
        /// <summary>
        /// The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 
        /// 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.
        /// Let d1 be the 1st digit, d2 be the 2nd digit, and so on.In this way, we note the following:
        ///  d2d3d4= 406 is divisible by 2
        ///d3d4d5= 063 is divisible by 3
        ///d4d5d6= 635 is divisible by 5
        ///d5d6d7= 357 is divisible by 7
        ///d6d7d8= 572 is divisible by 11
        ///d7d8d9= 728 is divisible by 13
        ///d8d9d10= 289 is divisible by 17
        ///Find the sum of all 0 to 9 pandigital numbers with this property.
        /// </summary>
        public static int[] perm = new int[] { 1, 0, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main (string [] args)
        {
            
            long result = 0;
            int[] divisors = { 1, 2, 3, 5, 7, 11, 13, 17 };

            int count = 1;
            int numPerm = 3265920;

            while (count < numPerm)
            {
                int N = perm.Length;
                int i = N - 1;

                while (perm[i - 1] >= perm[i])
                {
                    i = i - 1;
                }

                int j = N;
                while (perm[j - 1] <= perm[i - 1])
                {
                    j = j - 1;
                }

                // swap values at position i-1 and j-1
                swap(i - 1, j - 1);

                i++;
                j = N;

                while (i < j)
                {
                    swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                bool divisible = true;
                for (int k = 1; k < divisors.Length; k++)
                {

                    int num = 100 * perm[k] + 10 * perm[k + 1] + perm[k + 2];
                    if (num % divisors[k] != 0)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible)
                {
                    long num = 0;
                    for (int k = 0; k < perm.Length; k++)
                    {
                        num = 10 * num + perm[k];
                    }
                    result += num;
                }
                count++;
            }

            
            Console.WriteLine(result);
            Console.ReadKey();
    }
        static void swap(int i, int j)
        {
            int k = perm[i];
            perm[i] = perm[j];
            perm[j] = k;
        }

    }
}
