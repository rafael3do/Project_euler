using System;
using System.IO;


namespace ProjectEuler
{
    /// <summary>
    /// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
///3
///7 4
///2 4 6
///8 5 9 3
//That is, 3 + 7 + 4 + 9 = 23.
///Find the maximum total from top to bottom of the triangle below:
    /// </summary>
    class Problem18
    {
        static int[,] readInput(string filename)
        {
            string line;
            string[] linePieces;
            int lines = 0;

            StreamReader r = new StreamReader(filename);
            while ((line = r.ReadLine()) != null)
            {
                lines++;
            }

            int[,] inputTriangle = new int[lines, lines];
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputTriangle[j, i] = int.Parse(linePieces[i]);
                }
                j++;
            }
            r.Close();
            return inputTriangle;
        }
        static void Main(string[] args)
        {
            string filename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\input.txt";
            int[,] inputTriangle = readInput(filename);

            int posSolutions = (int)Math.Pow(2, inputTriangle.GetLength(0) - 1);
            int largestSum = 0;
            int tempSum, index;

            for (int i = 0; i <= posSolutions; i++)
            {
                tempSum = inputTriangle[0, 0];
                index = 0;
                for (int j = 0; j < inputTriangle.GetLength(0) - 1; j++)
                {
                    index = index + (i >> j & 1);
                    tempSum += inputTriangle[j + 1, index];
                }
                if (tempSum > largestSum)
                {
                    largestSum = tempSum;

                }
            }
            Console.WriteLine(largestSum.ToString());
            Console.ReadKey();
        }
    }
}
