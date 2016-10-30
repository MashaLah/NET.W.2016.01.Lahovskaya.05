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
        /// Sorts jagget array by row's sum.
        /// </summary>
        public static void SortSum(int[][] jaggedArr)
        {
            Sort(jaggedArr, sortBySum);
        }

        /// <summary>
        /// Sorts jagget array by row's max element.
        /// </summary>
        public static void SortMax(int[][] jaggedArr)
        {
            Sort(jaggedArr, sortByMax);
        }

        /// <summary>
        /// Sorts jagget array by row's min element.
        /// </summary>
        public static void SortMin(int[][] jaggedArr)
        {
            Sort(jaggedArr, sortByMin);
        }

        /// <summary>
        /// Sorts jagget array.
        /// </summary>
        /// <exception>
        /// Neither jagged array nor nested array can be null and can have length = 0.
        /// </exception>
        private static void Sort(int[][] jaggedArr, Func<int[],int> sortingFunction)
        {
            if (jaggedArr == null)
            {
                throw new ArgumentNullException($"{nameof(jaggedArr)} is null");
            }

            if (jaggedArr.Length == 0)
            {
                throw new ArgumentException($"Can't sort because {nameof(jaggedArr)} length = 0.");
            }

            if (jaggedArr.Any(el => el == null))
            {
                throw new ArgumentNullException($"Can't sort because nested in {nameof(jaggedArr)} array is null.");
            }

            if (jaggedArr.Any(el => el.Length == 0))
            {
                throw new ArgumentException($"Can't sort because nested in {nameof(jaggedArr)} array length = 0.");
            }

            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (sortingFunction(jaggedArr[j]) > sortingFunction(jaggedArr[j + 1]))
                    {
                        int[] temp = jaggedArr[j];
                        jaggedArr[j] = jaggedArr[j + 1];
                        jaggedArr[j + 1] = temp;
                    }
                }
            }
        }

        private static Func<int[], int> sortBySum = FindSum;
        private static Func<int[], int> sortByMax = FindMax;
        private static Func<int[], int> sortByMin = FindMin;

        /// <summary>
        /// Finds sum of elements.
        /// </summary>
        private static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        /// <summary>
        /// Finds min element.
        /// </summary>
        private static int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Finds max element.
        /// </summary>
        private static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
