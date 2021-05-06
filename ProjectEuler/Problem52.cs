using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem52
    {
        /// <summary>
        /// It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
        ///Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int start = 1;
            bool found = false;
            int result = 0;

            while (!found)
            {
                start *= 10;
                for (int i = start; i < start * 10 / 6; i++)
                {
                    found = true;
                    for (int j = 2; j <= 6; j++)
                    {
                        if (!isPerm(i, j * i))
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found)
                    {
                        result = i;
                        break;
                    }
                }
            }


            
            Console.WriteLine(result);
            Console.ReadKey();
        }



        static bool isPerm(int m, int n)
        {
            int[] arr = new int[10];

            int temp = n;
            while (temp > 0)
            {
                arr[temp % 10]++;
                temp /= 10;
            }

            temp = m;
            while (temp > 0)
            {
                arr[temp % 10]--;
                temp /= 10;
            }


            for (int i = 0; i < 10; i++)
            {
                if (arr[i] != 0) return false;
            }
            return true;
        }
    
    }
}
