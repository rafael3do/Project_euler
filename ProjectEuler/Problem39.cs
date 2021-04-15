using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem39
    {
        /// <summary>
        /// If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
        ///{20,48,52}, {24,45,51}, { 30,40,50}
        ///For which value of p ≤ 1000, is the number of solutions maximised?
        /// </summary>
        static void Main (string [] agrs)
        {
            int[] p = new int[1001];
            int result = 0;

            for (int a = 1; a < 999; a++)
            {
                for (int b = 1; b + a < 1000; b++)
                {
                    for (int c = 1; c + b + a < 1001; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            p[a + b + c]++;
                        }
                    }
                }
            }

            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] > p[result])
                {
                    result = i;
                }
            }        
            Console.WriteLine( result);
            Console.ReadKey();
        }
    }
}
