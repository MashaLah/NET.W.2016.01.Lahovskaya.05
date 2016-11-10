using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sorts jagget array.
        /// </summary>
        /// <param name="jaggedArr">Array of int[]</param>
        /// <param name="sortingFunction">Delegate to sorting function</param>
        /// <exception>
        /// Jagged array can't be null and can't have length = 0.
        /// </exception>
        public static void Sort(int[][] jaggedArr, Func<int[],int[],int> sortingFunction)
        {
            if (jaggedArr == null)
                throw new ArgumentNullException(nameof(jaggedArr));

            if (jaggedArr.Length == 0)
                throw new ArgumentException($"Can't sort because {nameof(jaggedArr)} length = 0.");

            if (sortingFunction == null)
                throw new ArgumentNullException(nameof(sortingFunction));

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (sortingFunction(jaggedArr[j],jaggedArr[j + 1])>0)
                    {
                        SwapArrays(ref jaggedArr[j], ref jaggedArr[j + 1]);
                    }
                }
            }
        }



        /// <summary>
        /// Invoke public static void Sort(int[][] jaggedArr, Func<int[],int[],int> sortingFunction).
        /// </summary>
        /// <param name="jaggedArr">Array of int[]</param>
        /// <param name="icomparator">Include sorting criteria</param>
        /// <exception>
        /// IComparer<int[]> icomparator can't be null.
        /// </exception>
        public static void Sort(int[][] jaggedArr, IComparer<int[]> icomparator)
        {
            if (icomparator == null)
                throw new ArgumentNullException(nameof(icomparator));
            Sort(jaggedArr, icomparator.Compare);
        }

        /// <summary>
        /// Swap 2 arrays of integer.
        /// </summary>
        /// <param name="firstArray">Array of intrger</param>
        /// <param name="secondArray">Array of integer</param>
        private static void SwapArrays(ref int[] firstArray, ref int[] secondArray)
        {
            int[] temp = firstArray;
            firstArray = secondArray;
            secondArray = temp;
        }
    }
}
