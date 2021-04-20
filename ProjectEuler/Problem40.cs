using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem40
    {
        /// <summary>
        /// An irrational decimal fraction is created by concatenating the positive integers:
        ///0.123456789101112131415161718192021...
        ///It can be seen that the 12th digit of the fractional part is 1.
        ///If dn represents the nth digit of the fractional part, find the value of the following expression.
        ///d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            long result = 1;
            List<long> counts = new List<long>() { 0 };
            long last = 0;
            for (long i = 0; last < 1000000; i++)
            {
                long count = (long)((i + 1) * 9 * (Math.Pow(10, (int)i)));
                last += count;
                counts.Add(last);
            }

            for (int i = 0; i <= 6; i++)
            {
                long digitN = (long)(Math.Pow(10, i) - 1);
                int n = counts.Count - 1;
                while (counts[n] > digitN)
                {
                    n--;
                }
                long x = (long)(Math.Pow(10, n) + (digitN - counts[n]) / (n + 1));
                long d = long.Parse(x.ToString()[(int)((digitN - counts[n]) % (n + 1))].ToString());
                result *= d;
                //Console.WriteLine("d{0} = {1}", digitN + 1, d);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}