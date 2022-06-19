using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem50
    {
        ///The prime 41, can be written as the sum of six consecutive primes:
        ///41 = 2 + 3 + 5 + 7 + 11 + 13
        ///This is the longest sum of consecutive primes that adds to a prime below one-hundred.
        ///The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
        ///Which prime, below one-million, can be written as the sum of the most consecutive primes?
        
        static void Main (string [] args)
        {

            const int limit = 1000000;
            long result = 0;
            int numberOfPrimes = 0;
            long[] primes = ESieve(1, limit);
            long[] primeSum = new long[primes.Length + 1];


            primeSum[0] = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                primeSum[i + 1] = primeSum[i] + primes[i];
            }

            for (int i = numberOfPrimes; i < primeSum.Length; i++)
            {
                for (int j = i - (numberOfPrimes + 1); j >= 0; j--)
                {

                    if (primeSum[i] - primeSum[j] > limit)
                    {
                        break;
                    }

                    if (Array.BinarySearch(primes, primeSum[i] - primeSum[j]) >= 0)
                    {
                        numberOfPrimes = i - j;
                        result = primeSum[i] - primeSum[j];
                    }
                }
            }

           
            Console.WriteLine( result);
            Console.ReadKey();
        }

        public static long[] ESieve(int lowerLimit, int upperLimit)
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

            List<long> numbers = new List<long>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));

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
