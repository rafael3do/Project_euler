using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem40
    {
		/// <summary>
		/// 
		/// </summary>
		/// <param name="args"></param>
        static void Main (string [] args)
        {
			int prod = 1;
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i < 1000000; i++)
			{
				sb.Append(i);

				
				for (int j = 1; j <= 6; j++)
				{
					//prod * = (i / (int)pow(10, digits - j - 1)) % 10; /* retrieve i's j-th digit */
					prod *= (j / (int)Math.Pow(10, 6 - j - 1)) % 10;
					//prod *= sb[(Math.Pow(10.0, j) - 1.0) - '0'];
				}
			}
			Console.WriteLine(prod);
			Console.ReadKey();
		

	}
    }
}
