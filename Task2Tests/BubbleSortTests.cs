using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task2;

namespace Task2Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        /// <summary>
        /// A test for SortSum.
        /// </summary>
        [Test]
        public void SortSum_JaggetArray_SortedJaggetArray()
        {
            //arrange
            int[][] jArray = 
            {
                new int[] {1, 2},
                new int[] {3, 3, 5, 6},
                new int[] {1, 2, 3}
            };
            int[][] expected =
            {
                new int[] {1, 2},
                new int[] {1, 2, 3},
                new int[] {3, 3, 5, 6}
            };
            //act
            BubbleSort.SortSum(jArray);
            //assert
            Assert.AreEqual(expected,jArray);
        }

        /// <summary>
        /// A test for SortMax.
        /// </summary>
        [Test]
        public void SortMax_JaggedArray_SortedJaggedArray()
        {
            //arrange
            int[][] jArray =
            {
                new int[] {1, 2},
                new int[] {3, 3, 5, 6},
                new int[] {1, 2, 3}
            };
            int[][] expected =
            {
                new int[] {1, 2},
                new int[] {1, 2, 3},
                new int[] {3, 3, 5, 6}
            };
            //act
            BubbleSort.SortMax(jArray);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for SortMin.
        /// </summary>
        [Test]
        public void SortMin_JaggedArray_SortedJaggedArray()
        {
            //arrange
            int[][] jArray =
            {
                new int[] {1, 2},
                new int[] {3, 3, 5, 6},
                new int[] {2, 3}
            };
            int[][] expected =
            {
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {3, 3, 5, 6}
            };
            //act
            BubbleSort.SortMin(jArray);
            //assert
            Assert.AreEqual(expected, jArray);
        }
    }
}
