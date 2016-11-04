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
        public static void Sort(int[][] jaggedArr, IComp icomparator) 
        {
            if (jaggedArr == null)
                throw new ArgumentNullException($"{nameof(jaggedArr)} is null");

            if (jaggedArr.Length == 0)
                throw new ArgumentException($"Can't sort because {nameof(jaggedArr)} length = 0.");

            if (icomparator == null)
                throw new ArgumentNullException($"{nameof(icomparator)} is null.");

            if (jaggedArr.Any(el => el.Length == 0))
                throw new ArgumentException($"Can't sort because nested in {nameof(jaggedArr)} array length = 0.");

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (icomparator.CompareTo(jaggedArr[j], jaggedArr[j + 1]) > 0)
                    {
                        SwapArrays(ref jaggedArr[j], ref jaggedArr[j + 1]);
                    }
                }
            }
        }

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
