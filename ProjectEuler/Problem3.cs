using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    ///</sumary>
    ///The prime factors of 13195 are 5, 7, 13 and 29.
    ///What is the largest prime factor of the number 600851475143 ?
    ///</sumary>
    class Problem3
    {
        public static bool Primo(int num)
        {
            int div = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    div++;
                }
            }
            return div == 2; 
        }

        static void Main(string[] args)
        {
            long num = Convert.ToInt64(Console.ReadLine());
            int i = 2;
           
            while (i<=num)
            {
                if ((num % i == 0))
                {
                    num = num / i;
                    Console.WriteLine(i);
                }
                else
                {
                    i =i+ 1;
                }
                
            }



            Console.ReadKey();
        }
    
        
    }
}
