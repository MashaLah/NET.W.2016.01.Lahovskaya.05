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
                throw new ArgumentException("array.Lendth must be > 1.", nameof(array));
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
