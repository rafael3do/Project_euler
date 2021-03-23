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
        /// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into 
        /// alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list
        /// to obtain a name score.
        /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So,
        /// COLIN would obtain a score of 938 × 53 = 49714.
        ///What is the total of all the name scores in the file?
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
