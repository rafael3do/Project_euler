using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Problem7
    {
        static void Main (string[] args)
        {
            List<long> numbers = new List<long>() {2};

            for (long i = 3; i < long.MaxValue; i += 2)
            {
                if (!numbers.Any(p => (i % p) == 0))
                {
                    numbers.Add(i);
                    if (numbers.Count == 10001)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
