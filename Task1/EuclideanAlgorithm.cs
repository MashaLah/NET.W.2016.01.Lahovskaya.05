using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// <exception>
        /// Array can't be null and can't contain only 0 and must be longer than 1.
        /// </exception>
        public static int FindGCD(out long time, params int[] array)
        {

            if (array == null)
            {
                throw new ArgumentNullException($"{nameof(array)} is null.");
            }

            if (array.Length < 2)
            {
                throw new ArgumentOutOfRangeException($"{nameof(array)}array.Lendth must be > 1.");
            }

            if (array.All(el => el==0))
            {
                throw new ArgumentException($"Every element of {nameof(array)} = 0.");
            }

            Stopwatch timer = new Stopwatch();

            timer.Start();

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                while (array[i] != 0)
                {
                    array[i] = result % (result = array[i]);
                }
            }

            timer.Stop();

            time = timer.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Call FindGCDByStein with a lot of numbers.
        /// </summary>
        /// <exception>
        /// Array can't be null and can't contain only 0 and must be longer than 1.
        /// </exception>
        public static int CallStein(out long time, params int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{nameof(array)} is null.");
            }

            if (array.Length < 2)
            {
                throw new ArgumentOutOfRangeException($"{nameof(array)} lendth must be > 1.");
            }

            if (array.All(el => el == 0))
            {
                throw new ArgumentException($"Every element of {nameof(array)} = 0.");
            }

            Stopwatch timer = new Stopwatch();

            timer.Start();

            if (array.Any(el => el == 1))
            {
                timer.Stop();
                time = timer.ElapsedMilliseconds;
                return 1;
            }

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = FindGCDByStein(result, array[i]);
            }

            timer.Stop();

            time = timer.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm.
        /// </summary>
        private static int FindGCDByStein(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
            {
                return secondNumber;
            }
            if (secondNumber == 0)
            {
                return firstNumber;
            }
            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }
            /*if (firstNumber == 1 || secondNumber == 1)
            {
                return 1;
            }*/
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                return 2 * FindGCDByStein(firstNumber / 2, secondNumber / 2);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return FindGCDByStein(firstNumber / 2, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return FindGCDByStein(firstNumber, secondNumber / 2);
            }
            return FindGCDByStein(secondNumber, Math.Abs(firstNumber - secondNumber));
        }

    }
}
