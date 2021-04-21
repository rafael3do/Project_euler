using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem42
    {
        /// <summary>
        /// The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
        ///1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        ///By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we 
        ///form a word value.For example, the word value for SKY is 19 + 11 + 25 = 55 = t10.If the word value is a triangle 
        ///number then we shall call the word a triangle word.
        //Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common
        //English words, how many are triangle words?
        /// </summary>
        /// <param name="args"></param>
        static void Main (string [] args)
        {

            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\input.txt";

            int result = 0;
            string[] words = readInput(filename);

            for (int i = 0; i < words.Length; i++)
            {
                double wordsum = (Math.Sqrt(1 + 8 * sum(words[i])) - 1.0) / 2.0;
                if (wordsum == ((int)wordsum))
                {
                    result++;
                }

            }

            
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string[] readInput(string filename)
        {
            StreamReader r = new StreamReader(filename);
            string line = r.ReadToEnd();
            r.Close();

            string[] names = line.Split(',');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim('"');
            }

            return names;
        }

        static int sum(string name)
        {
            int result = 0;
            for (int i = 0; i < name.Length; i++)
            {
                result += Convert.ToInt32(name[i]) - 64;
            }
            return result;
        }

    



}
}
