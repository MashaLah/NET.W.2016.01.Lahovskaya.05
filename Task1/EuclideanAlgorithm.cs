using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class EuclideanAlgorithm
    {
        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers.
        /// </summary>
        public static int FindGCD(int [] array)
        public static int FindGCD(params int[] array)
        {
            while (array[1] != 0)
            {
                array[1] = array[0] % (array[0] = array[1]);
            }
            int result = array[0];
            for (int i = 2; i < array.Length; i++)
            {
                while (array[i] != 0)
                {
                    array[i] = result % (result = array[i]);
                }
            }
            return result;
        }
    }
}
