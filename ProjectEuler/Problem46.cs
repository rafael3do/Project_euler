using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem46
    {
        /// <summary>
        /// It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.
        ///9 = 7 + 2×12
        ///15 = 7 + 2×22
        ///21 = 3 + 2×32
        ///25 = 7 + 2×32
        ///27 = 19 + 2×22
        ///33 = 31 + 2×12
        //It turns out that the conjecture was false.
        //What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] primeList = ESieve(10000);
            int result = 1;
            bool notFound = true;

            while (notFound)
            {
                result += 2;
                int j = 0;
                notFound = false;
                while (result >= primeList[j])
                {
                    if (isTwiceSquare(result - primeList[j]))
                    {
                        notFound = true;
                        break;
                    }
                    j++;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }


        static bool isTwiceSquare(long number)
        {
            double squareTest = Math.Sqrt(number / 2);
            return squareTest == ((int)squareTest);
        }

        static int[] ESieve(int upperLimit)
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
            numbers.Add(2);
            for (int i = 1; i <= sieveBound; i++)
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
