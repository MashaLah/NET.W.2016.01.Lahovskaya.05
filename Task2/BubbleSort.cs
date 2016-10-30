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
        /// Sorts jagget array by rows sum.
        /// </summary>
        public static void SortSum(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (FindSum(jaggedArr[j]) > FindSum(jaggedArr[j + 1]))
                    {
                        int[] temp = jaggedArr[j];
                        jaggedArr[j] = jaggedArr[j + 1];
                        jaggedArr[j + 1] = temp;
                    }
                }
            }
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

        /// <summary>
        /// Sorts jagget array by rows max element.
        /// </summary>
        public static void SortMax(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (FindMax(jaggedArr[j]) > FindMax(jaggedArr[j + 1]))
                    {
                        int[] temp = jaggedArr[j];
                        jaggedArr[j] = jaggedArr[j + 1];
                        jaggedArr[j + 1] = temp;
                    }
                }
            }
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
        /// Sorts jagget array by rows min element.
        /// </summary>
        public static void SortMin(int[][] jaggedArr)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr.Length - i - 1; j++)
                {
                    if (FindMin(jaggedArr[j]) > FindMin(jaggedArr[j + 1]))
                    {
                        int[] temp = jaggedArr[j];
                        jaggedArr[j] = jaggedArr[j + 1];
                        jaggedArr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
