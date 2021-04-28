using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler
{
    class Problem47
    {
        /// <summary>
        /// The first two consecutive numbers to have two distinct prime factors are:
        ///14 = 2 × 7
        ///15 = 3 × 5
        ///The first three consecutive numbers to have three distinct prime factors are:
        ///644 = 2² × 7 × 23
        ///645 = 3 × 5 × 43
        ///646 = 2 × 17 × 19.
        ///Find the first four consecutive integers to have four distinct prime factors each.What is the first of these numbers?
        /// </summary>
        /// <param name="args"></param>
        static int[] primeList;
         static void Main (string [] args)
        {
           
            primeList = ESieve(100000);
            int targetpf = 4;
            int targetConsec = 4;
            int consec = 1;
            int result = 2 * 3 * 5 * 7;

            while (consec < targetConsec)
            {
                result++;

                if (NumberOfPrimeFacors(result) >= targetpf)
                {
                    consec++;
                }
                else
                {
                    consec = 0;
                }
            }

     
            Console.WriteLine( result - targetConsec + 1);
            Console.ReadKey();
        }

        static int NumberOfPrimeFacors(int number)
        {
            int nod = 0;
            bool pf;
            int remain = number;

            for (int i = 0; i < primeList.Length; i++)
            {

                // In case there is a remainder this is a prime factor as well
                // The exponent of that factor is 1
                if (primeList[i] * primeList[i] > number)
                {
                    return ++nod;
                }

                pf = false;
                while (remain % primeList[i] == 0)
                {
                    pf = true;
                    remain = remain / primeList[i];
                }
                if (pf)
                {
                    nod++;
                }

                //If there is no remainder, return the count
                if (remain == 1)
                {
                    return nod;
                }
            }
            return nod;
        }

        // Returns the list of prime numbers up to the input
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
