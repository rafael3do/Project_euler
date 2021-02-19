using System;


namespace ProjectEuler
{
    ///</sumary>
    ///The prime factors of 13195 are 5, 7, 13 and 29.
    ///What is the largest prime factor of the number 600851475143 ?
    ///</sumary>
    class Problem3
    {
        
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
