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
        /// Finds the greatest common divisor (GCD) of 2 numbers using Euclidean algorithm.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <exception cref="ArgumentException">
        /// Both numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GCD</returns>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber) =>
            GCDMethod(firstNumber, secondNumber, EuclideMethod);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <exception cref="ArgumentException">
        /// Both numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GCD</returns>
        public static int GCDSteinMethod(int firstNumber, int secondNumber) =>
           GCDMethod(firstNumber, secondNumber, SteinMethod);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Euclidean algorithm with time.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="time">Out parameter. Shows time of running</param>
        /// <exception cref="ArgumentException">
        /// Both numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber, out long time) =>
            GCDMethod(firstNumber, secondNumber, EuclideMethod, out time);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm with time.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="time">Out parameter. Shows time of running</param>
        /// <exception cref="ArgumentException">
        /// Both numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDSteinMethod(int firstNumber, int secondNumber, out long time) =>
           GCDMethod(firstNumber, secondNumber, SteinMethod, out time);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers using Euclidean algorithm.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="thirdNumber">Integer number</param>
        /// <exception cref="ArgumentException">
        /// All numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber, int thirdNumber) =>
            GCDMethod(firstNumber, secondNumber, thirdNumber, EuclideMethod);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers using Stein's algorithm.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="thirdNumber">Integer number</param>
        /// <exception cref="ArgumentException">
        /// All numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDSteinMethod(int firstNumber, int secondNumber, int thirdNumber) =>
            GCDMethod(firstNumber, secondNumber, thirdNumber, SteinMethod);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers using Euclidean algorithm with time.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="thirdNumber">Integer number</param>
        /// <param name="time">Out parameter. Shows time of running.</param>
        /// <exception cref="ArgumentException">
        /// All numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDEuclideMethod(int firstNumber, int secondNumber, int thirdNumber, out long time) =>
            GCDMethod(firstNumber, secondNumber, thirdNumber, EuclideMethod, out time);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 3 numbers using Stein's algorithm with time.
        /// </summary>
        /// <param name="firstNumber">Integer number</param>
        /// <param name="secondNumber">Integer number</param>
        /// <param name="thirdNumber">Integer number</param>
        /// <param name="time">Out parameter. Shows time of running.</param>
        /// <exception cref="ArgumentException">
        /// All numbers can't be = 0 at the same time.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDSteinMethod(int firstNumber, int secondNumber, int thirdNumber, out long time) =>
            GCDMethod(firstNumber, secondNumber, thirdNumber, SteinMethod, out time);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of numbers in array using Euclidean algorithm.
        /// </summary>
        /// <param name="array">Array of integer</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Array must be longer than 1.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Array can't contain only 0.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Array can't be null.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDEuclideMethod(params int[] array) =>
            GCDMethod(EuclideMethod, array);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of numbers in array using Stein's algorithm.
        /// </summary>
        /// <param name="array">Array of integer</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Array must be longer than 1.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Array can't contain only 0.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Array can't be null.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDSteinMethod(params int[] array)=>
            GCDMethod(SteinMethod, array);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of numbers in array using Euclidean algorithm with time.
        /// </summary>
        /// <param name="time">Out parameter. Shows time of running.</param>
        /// <param name="array">Array of integer</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Array must be longer than 1.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Array can't contain only 0.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Array can't be null.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDEuclideMethod(out long time, params int[] array) =>
            GCDMethod(out time, EuclideMethod, array);

        /// <summary>
        /// Finds the greatest common divisor (GCD) of numbers in array using Stein's algorithm with time.
        /// </summary>
        /// <param name="time">Out parameter. Shows time of running.</param>
        /// <param name="array">Array of integer</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Array must be longer than 1.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Array can't contain only 0.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Array can't be null.
        /// </exception>
        /// <returns>GDC</returns>
        public static int GCDSteinMethod(out long time, params int[] array)=>
            GCDMethod(out time, SteinMethod, array);

        private static int GCDMethod(int firstNumber, int secondNumber, Func<int, int, int> GCDFunction)
        {
            CheckExceptionsForTwo(firstNumber, secondNumber);
            return GCDFunction(firstNumber, secondNumber);
        }

        private static int GCDMethod(Func<int, int, int> GDCFunction, params int[] array)
        {
            CheckExceptions(array);

            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                result = GCDMethod(result, array[i], GDCFunction);
            }

            return Math.Abs(result);
        }

        public static int GCDMethod(out long time, Func<int, int, int> GDCFunction, params int[] array)
        {
            CheckExceptions(array);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDMethod(GDCFunction,array);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        private static int GCDMethod(int firstNumber, int secondNumber, Func<int, int, int> GCDFunction, out long time)
        {
            CheckExceptionsForTwo(firstNumber, secondNumber);

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDFunction(firstNumber, secondNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        private static int GCDMethod(int firstNumber, int secondNumber, int thirdNumber, Func<int, int, int> GCDFunction)
        {
            CheckExceptionsForThree(firstNumber, secondNumber, thirdNumber);
            return GCDFunction(GCDFunction(firstNumber, secondNumber), thirdNumber);
        }

        private static int GCDMethod(int firstNumber, int secondNumber, int thirdNumber, Func<int, int, int> GCDFunction, out long time)
        {
            CheckExceptionsForThree(firstNumber, secondNumber, thirdNumber);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = GCDFunction(GCDFunction(firstNumber, secondNumber), thirdNumber);
            timer.Stop();
            time = timer.Elapsed.Ticks;
            return result;
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers by Euclidean algorithm.
        /// </summary>
        private static int EuclideMethod(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
                secondNumber = firstNumber % (firstNumber = secondNumber);
            
            return Math.Abs(firstNumber);
        }

        /// <summary>
        /// Finds the greatest common divisor (GCD) of 2 numbers using Stein's algorithm.
        /// </summary>
        private static int SteinMethod(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0)
                return Math.Abs(secondNumber);

            if (secondNumber == 0)
                return Math.Abs(firstNumber);
     
            if (firstNumber == secondNumber)
                return Math.Abs(firstNumber);
            
            if (firstNumber == 1 || secondNumber == 1)
                return 1;
            
            if ((firstNumber % 2 == 0) && (secondNumber % 2 == 0))
                return 2 * SteinMethod(firstNumber / 2, secondNumber / 2);
            
            if ((firstNumber % 2 == 0) && (secondNumber % 2 != 0))
                return SteinMethod(firstNumber / 2, secondNumber);
            
            if ((firstNumber % 2 != 0) && (secondNumber % 2 == 0))
                return SteinMethod(firstNumber, secondNumber / 2);
            
            return SteinMethod(secondNumber, Math.Abs(firstNumber - secondNumber));
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
                throw new ArgumentNullException($"{nameof(array)} is null.");

            if (array.Length < 2)
                throw new ArgumentOutOfRangeException($"{nameof(array)}array.Lendth must be > 1.");

            if (array.All(el => el == 0))
                throw new ArgumentException($"Every element of {nameof(array)} = 0.");
        }

        /// <summary>
        /// Check input 2 numbers.
        /// </summary>
        /// <exception>
        /// Both numbers can't be = 0 at the same time.
        /// </exception>
        private static void CheckExceptionsForTwo(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 && secondNumber == 0)
                throw new ArgumentException($"{nameof(firstNumber)} and {nameof(secondNumber)} = 0.");
        }

        /// <summary>
        /// Check input array.
        /// </summary>
        /// <exception>
        /// All numbers can't be = 0 at the same time
        /// </exception>
        private static void CheckExceptionsForThree(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0)
                throw new ArgumentException($"{nameof(firstNumber)} and {nameof(secondNumber)} and {nameof(thirdNumber)} = 0.");
        }
    }
}
