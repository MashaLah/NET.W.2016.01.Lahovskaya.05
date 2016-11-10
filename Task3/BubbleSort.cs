using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sorts jagget array.
        /// </summary>
        /// <exception>
        /// Neither jagged array nor nested array can be null and can have length = 0.
        /// </exception>
        public static void Sort(int[][] jaggedArr, IComparer<int[]> icomparator) 
        {
            if (jaggedArr == null)
                throw new ArgumentNullException(nameof(jaggedArr));

            if (jaggedArr.Length == 0)
                throw new ArgumentException($"Can't sort because {nameof(jaggedArr)} length = 0.");

            if (icomparator == null)
                throw new ArgumentNullException(nameof(icomparator));

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (icomparator.Compare(jaggedArr[j], jaggedArr[j + 1]) > 0)
                    {
                        SwapArrays(ref jaggedArr[j], ref jaggedArr[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        /// Sorts jagget array.
        /// </summary>
        /// <param name="jaggedArr">Array int[][]</param>
        /// <param name="sortingFunction">Delegate, 2 input arrays of integer, return integer</param>
        public static void Sort(int[][] jaggedArr, Func<int[],int[], int> sortingFunction)
        {
            if (sortingFunction == null)
                throw new ArgumentNullException(nameof(sortingFunction));

            Adapter adapter = new Adapter(sortingFunction);
            Sort(jaggedArr,adapter);
        }

        /// <summary>
        /// Swap 2 arrays of integer.
        /// </summary>
        /// <param name="firstArray">Array of intrger</param>
        /// <param name="secondArray">Array of integer</param>
        private static void SwapArrays(ref int[] firstArray,ref int[] secondArray)
        {
            int[] temp = firstArray;
            firstArray = secondArray;
            secondArray = temp;
        }
    }

    public interface IComp
    {
        int CompareTo(int[] firstArray, int[] secondArray);
    }
}
