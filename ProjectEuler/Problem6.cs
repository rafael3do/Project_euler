using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// The square of the sum of the first ten natural numbers is,
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        /// </summary>

        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0 ;
            int sub = 0;
            for (int i=0;i<=100;i++)
            {

                sum += i * i;
                num += i;
            }
            num = num * num;
            sub = num - sum;
          
            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}
