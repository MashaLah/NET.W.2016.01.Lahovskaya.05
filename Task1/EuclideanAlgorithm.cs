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
        /// Finds the greatest common divisor (GCD) of 2 numbers by Euclidean algorithm.
        /// </summary>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
            {
                secondNumber = firstNumber % (firstNumber = secondNumber);
            }
            return firstNumber;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm.
        /// </summary>
        public static int GCDSteinMethod(int firstNumber, int secondNumber)
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
            if (firstNumber == 1 || secondNumber == 1)
            {
                return 1;
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
            {
                return 2 * GCDSteinMethod(firstNumber / 2, secondNumber / 2);
            }
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
            {
                return GCDSteinMethod(firstNumber / 2, secondNumber);
            }
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
            {
                return GCDSteinMethod(firstNumber, secondNumber / 2);
            }
            return GCDSteinMethod(secondNumber, Math.Abs(firstNumber - secondNumber));
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm with time.
        /// </summary>
        public static int GCDSteinMethod(int firstNumber, int secondNumber, out long time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDSteinMethod(firstNumber,secondNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Euclidean algorithm with time.
        /// </summary>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber, out long time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDEuclideMethod(firstNumber, secondNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers by Euclidean algorithm.
        /// </summary>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            int firstGDC = GCDEuclideMethod(firstNumber, secondNumber);
            int result = GCDEuclideMethod(firstGDC, thirdNumber);
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers by Euclidean algorithm.
        /// </summary>
        public static int GCDSteinMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            int firstGDC = GCDSteinMethod(firstNumber, secondNumber);
            int result = GCDSteinMethod(firstGDC, thirdNumber);
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers by Euclidean algorithm with time.
        /// </summary>
        public static int GDCEuclideAlgoritm(int firstNumber, int secondNumber, int thirdNumber, out long time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDEuclideMethod(firstNumber, secondNumber, thirdNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers by Stein's algorithm with time.
        /// </summary>
        public static int GDCSteinAlgoritm(int firstNumber, int secondNumber, int thirdNumber, out long time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDSteinMethod(firstNumber, secondNumber, thirdNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers by Euclidean algorithm.
        /// </summary>
        public static int GCDEuclideMethod(params int[] array)
        {
            CheckExceptions(array);

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

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers by Euclidean algorithm with time.
        /// </summary>
        public static int GCDEuclideMethod(out long time, params int[] array)
        {
            CheckExceptions(array);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDEuclideMethod(array);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers by Stein's algorithm.
        /// </summary>
        public static int GCDSteinMethod(params int[] array)
        {
            CheckExceptions(array);

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = GCDSteinMethod(result, array[i]);
            }

            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers by Stein's algorithm with time.
        /// </summary>
        public static int GCDSteinMethod(out long time, params int[] array)
        {
            CheckExceptions(array);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDSteinMethod(array);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Check input array.
        /// </summary>
        /// <exception>
        /// Array can't be null and can't contain only 0 and must be longer than 1.
        /// </exception>
        private static void CheckExceptions(params int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"{nameof(array)} is null.");
            }

            if (array.Length < 2)
            {
                throw new ArgumentOutOfRangeException($"{nameof(array)}array.Lendth must be > 1.");
            }

            if (array.All(el => el == 0))
            {
                throw new ArgumentException($"Every element of {nameof(array)} = 0.");
            }
        }
    }
}
