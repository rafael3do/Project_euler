using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem33
    {
        /// <summary>
        /// The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may 
        /// incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        ///We shall consider fractions like, 30/50 = 3/5, to be trivial examples.       
        ///There are exactly four non-trivial examples of this type of fraction, less than one in value, 
        ///and containing two digits in the numerator and denominator.     
        ///If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
        /// </summary>
       
        static void Main (string[] args)
        {

            int denproduct = 1;
            int nomproduct = 1;

            for (int i = 1; i < 10; i++)
            {
                for (int den = 1; den < i; den++)
                {
                    for (int nom = 1; nom < den; nom++)
                    {
                        if ((nom * 10 + i) * den == nom * (i * 10 + den))
                        {
                            denproduct *= den;
                            nomproduct *= nom;
                        }
                    }
                }
            }

            denproduct /= gcd(nomproduct, denproduct);

            
            Console.WriteLine(denproduct);
            Console.ReadKey();
        }
       

        static int gcd(int a, int b)
        {
            int y, x;

            if (a > b)
            {
                x = a;
                y = b;
            }
            else
            {
                x = b;
                y = a;
            }

            while (x % y != 0)
            {
                int temp = x;
                x = y;
                y = temp % x;
            }

            return y;
        }
    }
}
