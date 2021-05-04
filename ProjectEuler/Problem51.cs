using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem51
    {
        /// <summary>
        /// By replacing the 1st digit of the 2-digit number *3, it turns out that six of the nine possible values: 13, 23, 43, 53, 73, and 83,
        /// are all prime.
        /// By replacing the 3rd and 4th digits of 56**3 with the same digit, this 5-digit number is the first example having seven primes 
        /// among the ten generated numbers, yielding the family: 56003, 56113, 56333, 56443, 56663, 56773, and 56993. Consequently 56003,
        /// being the first member of this family, is the smallest prime with this property.
        /// Find the smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit, is part
        /// of an eight prime value family.
        /// </summary>
        /// <param name="args"></param>
        static void Main (string [] args)
        {

            int[][] fiveDigitPattern = get5digitPatterns();
            int[][] sixDigitPattern = get6digitPatterns();
            int result = int.MaxValue;

            for (int i = 11; i < 1000; i += 2)
            {

                //Only 1,3,7,9 are valid endings
                if (i % 5 == 0) continue;

                int[][] patterns = (i < 100) ?
                    fiveDigitPattern : sixDigitPattern;

                for (int j = 0; j < patterns.GetLength(0); j++)
                {
                    for (int k = 0; k <= 2; k++)
                    {

                        //Don't generate candidates with leading zero
                        if (patterns[j][0] == 0 && k == 0) continue;

                        int[] pattern = fillPattern(patterns[j], i);
                        int candidate = generateNumber(k, pattern);

                        if (candidate < result && isPrime(candidate))
                        {
                            if (familySize(k, pattern) == 8)
                                result = candidate;
                            break;
                        }
                    }
                }
            }

            
            Console.WriteLine("First prime in the eight prime family is {0}", result);
            Console.ReadKey();
        }

        static int familySize(int repeatingNumber, int[] pattern)
        {
            int familySize = 1;

            for (int i = repeatingNumber + 1; i < 10; i++)
            {
                if (isPrime(generateNumber(i, pattern))) familySize++;
            }

            return familySize;
        }

        static int[] fillPattern(int[] pattern, int number)
        {
            int[] filledPattern = new int[pattern.Length];
            int temp = number;

            for (int i = filledPattern.Length - 1; 0 <= i; i--)
            {
                if (pattern[i] == 1)
                {
                    filledPattern[i] = temp % 10;
                    temp /= 10;
                }
                else
                {
                    filledPattern[i] = -1;
                }
            }
            return filledPattern;
        }

        static int generateNumber(int repNumber, int[] filledPattern)
        {
            int temp = 0;
            for (int i = 0; i < filledPattern.Length; i++)
            {
                temp = temp * 10;
                temp += (filledPattern[i] == -1) ?
                    repNumber : filledPattern[i];
            }
            return temp;
        }

        static int[][] get5digitPatterns()
        {
            int[][] retVal = new int[4][];

            retVal[0] = new int[] { 1, 0, 0, 0, 1 };
            retVal[1] = new int[] { 0, 1, 0, 0, 1 };
            retVal[2] = new int[] { 0, 0, 1, 0, 1 };
            retVal[3] = new int[] { 0, 0, 0, 1, 1 };

            return retVal;
        }

        static int[][] get6digitPatterns()
        {
            int[][] retVal = new int[10][];

            retVal[0] = new int[] { 1, 1, 0, 0, 0, 1 };
            retVal[1] = new int[] { 1, 0, 1, 0, 0, 1 };
            retVal[2] = new int[] { 1, 0, 0, 1, 0, 1 };
            retVal[3] = new int[] { 1, 0, 0, 0, 1, 1 };
            retVal[4] = new int[] { 0, 1, 1, 0, 0, 1 };
            retVal[5] = new int[] { 0, 1, 0, 1, 0, 1 };
            retVal[6] = new int[] { 0, 1, 0, 0, 1, 1 };
            retVal[7] = new int[] { 0, 0, 1, 1, 0, 1 };
            retVal[8] = new int[] { 0, 0, 1, 0, 1, 1 };
            retVal[9] = new int[] { 0, 0, 0, 1, 1, 1 };

            return retVal;
        }


        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;

            int counter = 5;
            while ((counter * counter) <= n)
            {
                if (n % counter == 0) return false;
                if (n % (counter + 2) == 0) return false;
                counter += 6;
            }

            return true;
        
        }
    }
}
