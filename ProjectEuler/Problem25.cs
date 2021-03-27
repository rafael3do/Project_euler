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
