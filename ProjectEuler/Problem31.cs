using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem31
    {
        /// <summary>
        /// In the United Kingdom the currency is made up of pound (£) and pence (p). There are eight coins in general circulation:
        ///1p, 2p, 5p, 10p, 20p, 50p, £1 (100p), and £2 (200p).
        ///It is possible to make £2 in the following way:
        ///1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
        ///How many different ways can £2 be made using any number of coins?
        /// </summary>

        static void Main (string [] args)
        {
            int target = 200;
            int[] coinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[target + 1];
            ways[0] = 1;

            for (int i = 0; i < coinSizes.Length; i++)
            {
                for (int j = coinSizes[i]; j <= target; j++)
                {
                    ways[j] += ways[j - coinSizes[i]];
                }
            }
            Console.WriteLine(ways[ways.Length - 1]);
            Console.ReadKey();
        }
    }
}
