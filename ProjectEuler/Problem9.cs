using System;

namespace ProjectEuler
{
    /// <summary>
    /// Um tripleto pitagórico é um conjunto de três números naturais, a < b < c , para os quais,
    /// Por exemplo, 3 2 + 4 2 = 9 + 16 = 25 = 5 2 .
    /// Existe exatamente um tripleto pitagórico para o qual a + b + c = 1000.
    /// Encontre o produto abc .
    /// </summary>
    class Problem9
    {
        static void Main (string [] args)
        {
            int sum = 1000;
            for (int i = 0; i <= sum; i++)
            {
                for (int j =i+1;j<=sum;j++)
                {
                    for (int k = j + 1; k <= sum; k++)
                    {                       
                        if ((i * i) + (j * j) == (k * k) && ((i + j + k == sum)))
                        {
                            Console.WriteLine(i + " " + j + " " + k);
                            Console.WriteLine(i * j * k);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
