﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// </summary>
    /// Each new term in the Fibonacci sequence is generated by 
    /// adding the previous two terms. By starting with 1 and 2,
    /// the first 10 terms will be:
    ///1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    //By considering the terms in the Fibonacci 
    //sequence whose values do not exceed four million,
    //find the sum of the even-valued terms.   
    /// </summary>

    class Problem2
    {
        static void Main(string [] args)
        {
            int a = 1;
            int b = 2;
            int sum =0;
            for (int i=0;sum<=4000000;i++)
            {
                if (a%2==0)
                {
                    sum +=a;
                }
                if (b%2==0)
                {
                    sum += b;
                }
                              
                a = a + b;
                b = a + b;

            }
            Console.WriteLine("Sum:"+ sum);
            Console.ReadKey();
        }
    }
}
