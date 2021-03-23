using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem22
    {
      /// <summary>
      /// 
      /// </summary>
 
        static void Main (string[] args)
        {
            StreamReader sr = new StreamReader("names.txt");
            string textNames = sr.ReadToEnd().Replace("/", "").Replace("\"", "");
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            long result = 0;
            string[] arr = textNames.Split(',');
            Array.Sort(arr);
            for (int i = 1; i <= arr.Length; i++)
            {
                int score = 0;
                foreach (var eachChar in arr[i - 1].ToCharArray())
                {
                    score += (Array.IndexOf(alpha, eachChar) + 1);
                }
                score *= i;
                result += score;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
