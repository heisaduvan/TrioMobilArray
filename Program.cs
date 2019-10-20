using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrioMobilArraySorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -2, 1, 3, -4, 5};
            Console.Write("En büyük toplam : " + maxSumSubset(myArray, 0, myArray.Length, 0));
            Console.ReadLine();
        }
        static int maxSumSubset(int[] array,int i, int n, int prev)
        {
            // base case: all elements are processed
            if (i == n)
            {
                return 0;
            }

            // recur by excluding current element
            int excl = maxSumSubset(array, i + 1, n, prev);
            int incl = 0;

            // include current element only if it is not adjacent
            // to previous element considered
            if (prev + 1 != i)
            {
                incl = maxSumSubset(array, i + 1, n, i) + array[i];
            }

            // return maximum sum we get by including or excluding
            // current item
            return Math.Max(incl, excl);
        }
    }
}
