using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem48
    {
        /// <summary>
        /// The series, 11 + 22 + 33 + ... + 1010 = 10405071317.
        //Find the last ten digits of the series, 11 + 22 + 33 + ... + 10001000.
        /// </summary>
        static void Main (string [] args)
        {

            long result = 0;
            long modulo = 10000000000;

            for (int i = 1; i <= 1000; i++)
            {
                long temp = i;
                for (int j = 1; j < i; j++)
                {
                    temp *= i;
                    if (temp >= long.MaxValue / 1000)
                    {
                        temp %= modulo;
                    }
                }

                result += temp;
                result %= modulo;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        
    }
    }
}
