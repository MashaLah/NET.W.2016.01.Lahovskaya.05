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
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="expected"></param>
        [TestCase(9, 18, 27, 9, 81)]
        [TestCase(9, 18, 27, 9)]
        [TestCase(9, 18, 27)]
        public void FindGCD_ValidNumbers_9Returned(int expected, params int [] array)
        {
            //act
            int actual = EuclideanAlgorithm.FindGCD(array);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
