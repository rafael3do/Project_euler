using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem25
    {
        ///The Fibonacci sequence is defined by the recurrence relation:
///Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
///Hence the first 12 terms will be:
        ///The 12th term, F12, is the first term to contain three digits.
///What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
        
        static void Main (string [] agrs)
        {

            int i = 0;
            int cnt = 2;
            BigInteger limit = BigInteger.Pow(10, 999);
            BigInteger[] fib = new BigInteger[3];

            fib[0] = 1;
            fib[2] = 1;

            while (fib[i] <= limit)
            {
                i = (i + 1) % 3;
                cnt++;
                fib[i] = fib[(i + 1) % 3] + fib[(i + 2) % 3];
            }
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
