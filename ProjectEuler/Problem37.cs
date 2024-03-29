﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProjectEuler
{
    /// <summary>
    /// The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
    ///Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
    ///NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
    /// </summary>
    class Problem37
    {
        public static int isPrimeLimit = 1000000;
        public static int[] primeList;

        static void Main (string [] args)
        {
            int result = 0;
            primeList = ESieve(isPrimeLimit);

            int count = 0;
            int i = 4;
            while (count < 11)
            {
                int rightTrunk = primeList[i];
                int leftTrunk = 0;
                int multiplier = 1;
                bool isTrunkPrime = true;

                while (rightTrunk > 0 && isTrunkPrime)
                {
                    leftTrunk += multiplier * (rightTrunk % 10);
                    isTrunkPrime = IsPrime(leftTrunk) && IsPrime(rightTrunk);

                    rightTrunk /= 10;
                    multiplier *= 10;
                }

                if (isTrunkPrime)
                {
                    count++;
                    result += primeList[i];
                }

                i++;
            }

           
            Console.WriteLine(result);
            Console.ReadKey();
        
    }
        static bool IsPrime(int number)
        {
            return Array.BinarySearch<int>(primeList, number) >= 0;
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
