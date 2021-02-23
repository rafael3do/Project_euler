using System;


namespace ProjectEuler
{
    ///</sumary>
    ///2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    ///</sumary>
    class Problem5
    {
        static int lcm(int a, int b)
        {
            return a / gcd(a, b) * b;
        }
        static void Main(string[] args)
        {
            int star = 1;
            for (int i = 2; i <= 20; i++)
            {
                star = lcm(star, i);
            }
            Console.WriteLine(star);
            Console.ReadKey();
        }
        
        static int gcd(int a, int b)
        {
            while (b != 0)
            {
                a %= b;
                a ^= b;
                b ^= a;
                a ^= b;
            }
            return a;
        }
    }
}
