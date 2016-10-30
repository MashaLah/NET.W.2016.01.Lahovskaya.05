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
        /// A test for FindGCD method.
        /// </summary>
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, 18, -27, 9, -81)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(9, 18, 27)]
        [TestCase(9, -18, 27)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        [TestCase(1, 10, 11, 13)]
        [TestCase(1, 10, 1, 13)]
        public void FindGCD_ValidNumbers_ValidReturned(int expected, params int [] array)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.FindGCD(out time, array);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// A test for FindGCD with null parameter.
        /// </summary>
        [Test]
        public void FindGCD_ArrayIsNull_ThrowsArgumentNullException()
        {
            long time;
            Assert.Throws < ArgumentNullException >(() => EuclideanAlgorithm.FindGCD(out time, null));
        }

        /// <summary>
        /// A test for FindGDC with only one number.
        /// </summary>
        [Test]
        public void FindGCD_ArrayLengthIsLessThan2_TrowsArgumentOutOfRangeException()
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.FindGCD(out time, 9));
        }

        /// <summary>
        /// A test for FindGCD when every element of array = 0.
        /// </summary>
        [Test]
        public void FindGCD_EveryElementOfArrayIs0_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.FindGCD(out time, 0, 0, 0));
        }

        /// <summary>
        /// A test for FindGCDByStein method.
        /// </summary>
        [TestCase(9, 18, 27)]
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, -18, 27, -9, 81)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(9, 9, 9)]
        [TestCase(9, 0, 9)]
        [TestCase(1, 10, 11, 13)]
        [TestCase(1, 10, 1, 13)]
        [TestCase(7, 7, 14)]
        [TestCase(32, 0, 0, 32)]
        [TestCase(2, 2, 4, 6)]
        public void CallStein_ValidArray_ValidResult(int expected, params int[] array)
        {
            //arrange
            long time;
            //act
            int actual = EuclideanAlgorithm.CallStein(out time, array);
            //assert
            Debug.WriteLine($"Run time: {time}");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for CallStein with null parameter.
        /// </summary>
        [Test]
        public void CallStein_ArrayIsNull_ThrowsArgumentNullException()
        {
            long time;
            Assert.Throws<ArgumentNullException>(() => EuclideanAlgorithm.CallStein(out time, null));
        }

        /// <summary>
        /// A test for CallStein with only one number.
        /// </summary>
        [Test]
        public void CallStein_ArrayLengthIsLessThan2_TrowsArgumentOutOfRangeException()
        {
            long time;
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.CallStein(out time, 9));
        }

        /// <summary>
        /// A test for CallStein when every element of array = 0.
        /// </summary>
        [Test]
        public void CallStein_EveryElementOfArrayIs0_ThrowsArgumentException()
        {
            long time;
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.CallStein(out time, 0, 0, 0));
        }
    }
}
