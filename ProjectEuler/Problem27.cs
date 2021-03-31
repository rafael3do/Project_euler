﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace ProjectEuler
{
    class Problem27
    {
        /// <summary>
        /// Euler published the remarkable quadratic formula:
        /// n² + n + 41
        ///It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39. However, when n = 40, 402 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, 
        ///and certainly when n = 41, 41² + 41 + 41 is clearly divisible by 41.        
        ///Using computers, the incredible formula  n² – 79n + 1601 was discovered, which produces 80 primes for the consecutive values n = 0 to 79. The product of
        ///the coefficients, -79 and 1601, is -126479.        
        ///Considering quadratics of the form:        
        ///n² + an + b, where |a| < 1000 and |b| < 1000
        ///where |n| is the modulus/absolute value of n
        ///e.g. |11| = 11 and |-4| = 4
        ///Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, 
        ///starting with n = 0.
        /// </summary>

        public static int[] primes;
        static void Main(string[] agrs)
        {

            Start();

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

        public static void Start()
        {

            int aMax = 0, bMax = 0, nMax = 0;

            primes = ESieve(87400);
            int[] bPos = ESieve(1000);

            for (int a = -999; a < 1001; a += 2)
            {
                for (int i = 1; i < bPos.Length; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        int n = 0;

                        int sign = (j == 0) ? 1 : -1;
                        int aodd = (i % 2 == 0) ? -1 : 0;
                        while (isPrime(Math.Abs(n * n + (a + aodd) * n + sign * bPos[i])))
                        {
                            n++;
                        }

                        if (n > nMax)
                        {
                            aMax = a;
                            bMax = bPos[i];
                            nMax = n;
                        }
                    }
                }
            }


            Console.WriteLine("Result: " + aMax * bMax); ;
            Console.ReadKey();

        }

        static bool isPrime(int testNumber)
        {
            int i = 0;
            while (primes[i] <= testNumber)
            {
                if (primes[i] == testNumber)
                {
                    return true;
                }
                i++;
            }
            return false;
        }



    }
}
