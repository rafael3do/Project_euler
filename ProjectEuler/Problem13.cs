using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
/// create in your desktop file input.txt and insert nubmer from problem13
/// </summary>
namespace ProjectEuler
{
    class Problem13
    {
        static void Main(string [] args)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\input.txt";

            BigInteger result = new BigInteger();
            string line;
            StreamReader r = new StreamReader(filename);

            while ((line = r.ReadLine()) != null)
            {
                result += BigInteger.Parse(line);
            }
            Console.WriteLine(result.ToString("D10"));
            Console.ReadKey();
            r.Close();
        }
    }
}
