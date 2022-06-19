using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem49
    {
        /// <summary>
        /// The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: 
        /// (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.
        ///There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but 
        ///there is one other 4-digit increasing sequence.
       /// What 12-digit number do you form by concatenating the three terms in this sequence?
        /// </summary>
        static void Main (string [] args)
        {
            const int limit = 10000;
            long result = 0;
            int[] primes = ESieve(1489, limit);

            for (int i = 0; i < primes.Length; i++)
            {
                for (int j = i + 1; j < primes.Length; j++)
                {
                    int k = primes[j] + (primes[j] - primes[i]);
                    if (k < limit && Array.BinarySearch(primes, k) >= 0)
                    {
                        if (isPerm(primes[i], primes[j]) && isPerm(primes[i], k))
                        {
                            result = concat(concat(primes[i], primes[j]), k);
                            break;
                            
                        }
                    }
                }
                if (result > 0)
                {
                    break;
                }
            }

        
            Console.WriteLine( result);
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


        static bool isPerm(int m, int n)
        {
            int[] arr = new int[10];

            int temp = n;
            while (temp > 0)
            {
                arr[temp % 10]++;
                temp /= 10;
            }

            temp = m;
            while (temp > 0)
            {
                arr[temp % 10]--;
                temp /= 10;
            }


            for (int i = 0; i < 10; i++)
            {
                if (arr[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }


        static int[] ESieve(int lowerLimit, int upperLimit)
        {

            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));

            if (lowerLimit < 3)
            {
                numbers.Add(2);
                lowerLimit = 3;
            }

            for (int i = (lowerLimit - 1) / 2; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }

    }
}

