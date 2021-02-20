using System;


namespace ProjectEuler
{
    ///</sumary>
    ///A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    ///Find the largest palindrome made from the product of two 3-digit numbers.
    ///</sumary>
    class Problem4
    {
        static int Palindromo(int n)
        {
            int maior = (int)Math.Pow(10, n) - 1;
            int menor = 1 + maior / 10; 
            int maiorproduto = 0;

            for (int i = maior; i >= menor; i--)
            {
                for (int j = i; j >= menor; j--)
                {
                    
                    int produto = i * j;
                    if (produto < maiorproduto)
                        break;
                    int num = produto;
                    int reverso = 0;

                    while (num != 0)
                    {
                        reverso = reverso * 10 + num % 10;
                        num /= 10;
                    }

                    
                    if (produto == reverso && produto > maiorproduto)
                        maiorproduto = produto;
                }
            }
            return maiorproduto;
        }

       
         static void Main(string[] args)
        {

            int n = 3;
            Console.Write(Palindromo(n));
            Console.ReadLine();
        }
    }

}

