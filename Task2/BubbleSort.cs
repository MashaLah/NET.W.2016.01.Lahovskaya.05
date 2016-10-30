using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class BubbleSort
    {
        /*private static int[] FindSum(int[][] jaggedArray)
        {
            int[] sum = new int[jaggedArray.Length];
            for (int i = 0; i <jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum[i] += jaggedArray[i][j];
                }
            }
            return sum;
        }*/

        private static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

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

       /* private static int[] FindMax(int[][] jaggedArray)
        {
            int[] max = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    
                }
            }
            return max;
        }*/
    }
}
