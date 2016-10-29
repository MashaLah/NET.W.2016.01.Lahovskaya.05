using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

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
        public void FindGCD_ValidNumbers_ValidReturned(int expected, params int [] array)
        {
            //act
            int actual = EuclideanAlgorithm.FindGCD(array);
            //assert
            Assert.AreEqual(expected,actual);
        }

        /// <summary>
        /// A test for FindGCD with null parameter.
        /// </summary>
        [Test]
        public void FindGCD_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws < ArgumentNullException >(() => EuclideanAlgorithm.FindGCD(null));
        }

        /// <summary>
        /// A test for FindGDC with only one number.
        /// </summary>
        [Test]
        public void FindGCD_ArrayLengthIsLessThan2_TrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => EuclideanAlgorithm.FindGCD(9));
        }

        /// <summary>
        /// A test for FindGCD when every element of array = 0.
        /// </summary>
        [Test]
        public void FindGCD_EveryElementOfArrayIs0_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => EuclideanAlgorithm.FindGCD(0, 0, 0));
        }
    }
}
