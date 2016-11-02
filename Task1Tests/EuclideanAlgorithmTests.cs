using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;
using System.Diagnostics;

namespace Task1Tests
{
    [TestFixture]
    public class EuclideanAlgorithmTests
    {
        /// <summary>
        /// A test for GDCEuclideMetod with 2 numbers.
        /// </summary>
        [TestCase(1, 1, 9)]
        [TestCase(9, 18, 27)]
        [TestCase(9, -9, 27)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        public void GDCEuclideMethod_2Numbers_ValidReturned(int expected, int firstNumber, int secondNumber)
        {
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(firstNumber, secondNumber);
            //assert
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// A test for GDCEuclideMetod with 2 numbers and time.
        /// </summary>
        [TestCase(1, 1, 9)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        [TestCase(9, 18, 27)]
        [TestCase(9, -9, 27)]
        public void GDCEuclideMethod_2NumbersAndTime_ValidReturned(int expected, int firstNumber, int secondNumber)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(firstNumber, secondNumber, out time);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GDCEuclideMetod with 3 numbers.
        /// </summary>
        [TestCase(9, -18, -27, -9)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(1, 10, 11, 13)]
        [TestCase(1, 10, 1, 13)]
        [TestCase(9, 0, 27, 9)]
        public void GDCEuclideMethod_3Numbers_ValidReturned(int expected, int firstNumber, int secondNumber, int thirdNumber)
        {
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(firstNumber, secondNumber, thirdNumber);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GDCEuclideMetod with 3 numbers and time.
        /// </summary>
        [TestCase(9, -18, -27, -9)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(1, -10, -11, -13)]
        [TestCase(1, 10, 1, 13)]
        [TestCase(9, 0, 27, 9)]
        public void GDCEuclideMethod_3NumbersAndTime_ValidReturned(int expected, int firstNumber, int secondNumber, int thirdNumber)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(firstNumber, secondNumber, thirdNumber, out time);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GDCEuclideMetod with array.
        /// </summary>
        [TestCase(1, 18, 1, 9, 81)]
        [TestCase(9, 18, 0, 9, 0)]
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, -18, -27, -9, -81)]
        public void GDCEuclideMethod_Array_ValidReturned(int expected, params int[] array)
        {
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GDCEuclideMetod with array and time.
        /// </summary>
        [TestCase(1, 18, 1, 9, 81)]
        [TestCase(9, 18, 0, 9, 0)]
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, -18, -27, -9, -81)]
        public void GDCEuclideMethod_ArrayAndTime_ValidReturned(int expected, params int[] array)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDEuclideMethod(out time, array);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDEuclideMethod with two 0.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_Two0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(0,0));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with two 0 and time.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_Two0AndTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(0, 0, out time));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with two 0.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_Three0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(0, 0, 0));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with two 0 and time.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_Three0AndTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(0, 0, 0, out time));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with null parameter and time.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_ArrayIsNullWithTime_ThrowsArgumentNullException()
        {
            long time;
            Assert.Throws < ArgumentNullException >(() => EuclideanAlgorithm.GCDEuclideMethod(out time, null));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with null parameter.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EuclideanAlgorithm.GCDEuclideMethod(null));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with only one number.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_ArrayLengthIsLessThan2WithTime_TrowsArgumentOutOfRangeException()
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.GCDEuclideMethod(out time, 9));
        }

        /// <summary>
        /// A test for GCDEuclideMethod with only one number.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_ArrayLengthIsLessThan2_TrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.GCDEuclideMethod(9));
        }

        /// <summary>
        /// A test for GCDEuclideMethod when every element of array = 0.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_EveryElementOfArrayIs0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(0, 0, 0, 0));
        }

        /// <summary>
        /// A test for GCDEuclideMethod when every element of array = 0.
        /// </summary>
        [Test]
        public void GCDEuclideMethod_EveryElementOfArrayIs0WithTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDEuclideMethod(out time, 0, 0, 0, 0));
        }

        /// <summary>
        /// A test for GDCSteinMetod with 2 numbers.
        /// </summary>
        [TestCase(1, 1, 9)]
        [TestCase(9, 18, 27)]
        [TestCase(9, -18, 27)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        public void GCDSteinMethod_2Numbers_ValidReturned(int expected, int firstNumber, int secondNumber)
        {
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(firstNumber, secondNumber);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with 2 numbers and time.
        /// </summary>
        [TestCase(1, 1, 9)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        [TestCase(9, 18, 27)]
        [TestCase(9, -9, 27)]
        public void GCDSteinMethod_2NumbersAndTime_ValidReturned(int expected, int firstNumber, int secondNumber)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(firstNumber, secondNumber, out time);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with 3 numbers.
        /// </summary>
        [TestCase(9, -18, -27, -9)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(1, 10, 11, 13)]
        [TestCase(1, 10, 1, 13)]
        [TestCase(9, 0, 27, 9)]
        public void GCDSteinMethod_3Numbers_ValidReturned(int expected, int firstNumber, int secondNumber, int thirdNumber)
        {
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(firstNumber, secondNumber, thirdNumber);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with 3 numbers and time.
        /// </summary>
        [TestCase(9, -18, -27, -9)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(1, -10, -11, -13)]
        [TestCase(1, 10, 1, 13)]
        [TestCase(9, 0, 27, 9)]
        public void GCDSteinMethod_3NumbersAndTime_ValidReturned(int expected, int firstNumber, int secondNumber, int thirdNumber)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(firstNumber, secondNumber, thirdNumber, out time);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with array.
        /// </summary>
        [TestCase(1, 18, 1, 9, 81)]
        [TestCase(9, 18, 0, 9, 0)]
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, -18, -27, -9, -81)]
        public void GCDSteinMethod_Array_ValidReturned(int expected, params int[] array)
        {
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with array and time.
        /// </summary>
        [TestCase(1, 18, 1, 9, 81)]
        [TestCase(9, 18, 0, 9, 0)]
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, -18, -27, -9, -81)]
        public void GCDSteinMethod_ArrayAndTime_ValidReturned(int expected, params int[] array)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.GCDSteinMethod(out time, array);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for GCDSteinMethod with two 0.
        /// </summary>
        [Test]
        public void GCDSteinMethod_Two0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(0, 0));
        }

        /// <summary>
        /// A test for GCDSteinMethod with two 0 and time.
        /// </summary>
        [Test]
        public void GCDSteinMethod_Two0AndTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(0, 0, out time));
        }

        /// <summary>
        /// A test for GCDSteinMethod with two 0.
        /// </summary>
        [Test]
        public void GCDSteinMethod_Three0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(0, 0, 0));
        }

        /// <summary>
        /// A test for GCDSteinMethod with two 0 and time.
        /// </summary>
        [Test]
        public void GCDSteinMethod_Three0AndTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(0, 0, 0, out time));
        }

        /// <summary>
        /// A test for GCDSteinMethod with null parameter and time.
        /// </summary>
        [Test]
        public void GCDSteinMethod_ArrayIsNullWithTime_ThrowsArgumentNullException()
        {
            long time;
            Assert.Throws<ArgumentNullException>(() => EuclideanAlgorithm.GCDSteinMethod(out time, null));
        }

        /// <summary>
        /// A test for GCDSteinMethod with null parameter.
        /// </summary>
        [Test]
        public void GCDSteinMethod_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => EuclideanAlgorithm.GCDSteinMethod(null));
        }

        /// <summary>
        /// A test for GCDSteinMethod with only one number.
        /// </summary>
        [Test]
        public void GCDSteinMethod_ArrayLengthIsLessThan2WithTime_TrowsArgumentOutOfRangeException()
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.GCDSteinMethod(out time, 9));
        }

        /// <summary>
        /// A test for GCDSteinMethod with only one number.
        /// </summary>
        [Test]
        public void GCDSteinMethod_ArrayLengthIsLessThan2_TrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.GCDSteinMethod(9));
        }

        /// <summary>
        /// A test for GCDSteinMethod when every element of array = 0.
        /// </summary>
        [Test]
        public void GCDSteinMethod_EveryElementOfArrayIs0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(0, 0, 0, 0));
        }

        /// <summary>
        /// A test for GCDSteinMethod when every element of array = 0.
        /// </summary>
        [Test]
        public void GCDSteinMethod_EveryElementOfArrayIs0WithTime_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.GCDSteinMethod(out time, 0, 0, 0, 0));
        }

    }
}
