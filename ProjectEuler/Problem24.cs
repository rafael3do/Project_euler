using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /// <summary>
    /// A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation
    /// of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it 
    /// lexicographic order. The lexicographic permutations of 0, 1 and 2 are:012   021   102   120   201   210
    /// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    /// </summary>
    class Problem24
    {
     
        static void Main  (string [] args)
        {
            int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int count = 1;
            int numPerm = 1000000;
            while (count < numPerm)
            {
                int N = perm.Length;
                int i = N - 1;
                while (perm[i - 1] >= perm[i])
                {
                    i = i - 1;

                }
                int j = N;
                while (perm[j - 1] <= perm[i - 1])
                {
                    j = j - 1;
                }
                
                swap(i - 1, j - 1);

                i++;
                j = N;
                while (i < j) {
                    swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                count++;
            }

            string permNum = "";
            for (int k = 0; k < perm.Length; k++) {
                permNum = permNum + perm[k];
            }
            Console.WriteLine(permNum);
            Console.ReadKey();
             void swap(int i, int j)
            {
                int k = perm[i];
                perm[i] = perm[j];
                perm[j] = k;
            }

        }
    }
}
