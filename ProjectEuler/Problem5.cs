using System;


namespace ProjectEuler
{
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
