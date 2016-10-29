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
        public static int FindGCD(params int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(array), "array.Lendth must be > 1.");
            }
            if (array.All(el => el==0))
            {
                throw new ArgumentException("Every element of array = 0.", nameof(array));
            }
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
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
