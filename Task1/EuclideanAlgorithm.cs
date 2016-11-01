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
        public static int CallStein(out long time, params int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCD(stein, array);
            timer.Stop();
            time = timer.ElapsedTicks;
            return result;
        }

        public static int FindGCD(out long time, params int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCD(euclide, array);
            timer.Stop();
            time = timer.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers.
        /// </summary>
        /// <exception>
        /// Array can't be null and can't contain only 0 and must be longer than 1.
        /// </exception>
        private static void CheckExceptions (params int[] array)
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
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm.
        /// </summary>
        public static int GCDSteinMethod(int firstNumber, int secondNumber)
        {
            CheckExceptions();
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

        private static int GCDSteinMethod(int firstNumber, int secondNumber, out long time)
        {
            CheckExceptions();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDSteinMethod(firstNumber,secondNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        public static int GCDEuclideMethod(int firstNumber, int secondNumber, out long time)
        {
            CheckExceptions();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDEuclideMethod(firstNumber, secondNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of some numbers by Euclidean algorithm.
        /// </summary>
        private static int GCDEuclideMethod(params int[] array)
        {
            CheckExceptions();
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

        private static int GCDEuclideMethod(out long time, params int[] array)
        {
            CheckExceptions();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDEuclideMethod(array);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        public static int GCDEuclideMethod(int firstNumber, int secondNumber)
        {
            CheckExceptions();
            while (secondNumber != 0)
            {
                secondNumber = firstNumber % (firstNumber = secondNumber);
            }
            return firstNumber;
        }

        private static int GCDEuclideMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            CheckExceptions();
            int firstGDC = GCDEuclideMethod(firstNumber, secondNumber);
            int result = GCDEuclideMethod(firstGDC, thirdNumber);
            return result;
        }

        /// <summary>
        /// Call FindGCDByStein with a lot of numbers.
        /// </summary>
        private static int GCDSteinMethod(params int[] array)
        {
            CheckExceptions();
            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = GCDSteinMethod(result, array[i]);
            }

            return result;
        }

        private static int GCDSteinMethod(int firstNumber, int secondNumber, int thirdNumber)
        {
            CheckExceptions();
            int firstGDC = GCDSteinMethod(firstNumber, secondNumber);
            int result = GCDSteinMethod(firstGDC, thirdNumber);
            return result;
        }
    }
}
