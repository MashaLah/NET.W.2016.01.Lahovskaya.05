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
        public void SortSum_JaggedArray_SortedJaggedArray()
        {
            //arrange
            int[][] jArray =
            {
                new int[] {-1, 2},
                new int[] {3, 3, 5, 6, 0},
                new int[] {1, 2, 3}
            };
            int[][] expected =
            {
                new int[] {-1, 2},
                new int[] {1, 2, 3},
                new int[] {3, 3, 5, 6, 0}
            };
            //act
            BubbleSort.SortSum(jArray);
            //assert
            Assert.AreEqual(expected, jArray);
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
                new int[] {-1, 2},
                new int[] {3, 3, 5, 6, 0},
                new int[] {1, 2, 3}
            };
            int[][] expected =
            {
                new int[] {-1, 2},
                new int[] {1, 2, 3},
                new int[] {3, 3, 5, 6, 0}
            };
            //act
            BubbleSort.SortMax(jArray);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for SortMin.
        /// </summary>
        [TestCase]
        public void SortMin_JaggedArray_SortedJaggedArray()
        {
            //arrange
            int[][] jArray =
            {
                new int[] {-1, 2},
                new int[] {3, 3, 5, 6},
                new int[] {2, 3, 0}
            };
            int[][] expected =
            {
                new int[] {-1, 2},
                new int[] {2, 3, 0},
                new int[] {3, 3, 5, 6}
            };
            //act
            BubbleSort.SortMin(jArray);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for SortSum with null parameter.
        /// </summary>
        [Test]
        public void SortSum_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortSum(null));
        }

        /// <summary>
        /// A test for SortMax with null parameter.
        /// </summary>
        [Test]
        public void SortMax_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortMax(null));
        }

        /// <summary>
        /// A test for SortMin with null parameter.
        /// </summary>
        [Test]
        public void SortMin_ArrayIsNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortMin(null));
        }

        /// <summary>
        /// A test for SortSum with empty array.
        /// </summary>
        [Test]
        public void SortSum_EmptyArray_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(()=>BubbleSort.SortSum(jaggedArray));
        }

        /// <summary>
        /// A test for SortMax with empty array.
        /// </summary>
        [Test]
        public void SortMax_EmptyArray_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(() => BubbleSort.SortMax(jaggedArray));
        }

        /// <summary>
        /// A test for SortMin with empty array.
        /// </summary>
        [Test]
        public void SortMin_EmptyArray_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(() => BubbleSort.SortMin(jaggedArray));
        }

        /// <summary>
        /// A test for SortSum with nested array is null.
        /// </summary>
        [Test]
        public void SortSum_NestedArrayIsNull_ThrowsArgumentNullException()
        {
            int[][] jaggedArray = new int[][] 
            {
               null,
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortSum(jaggedArray));
        }

        /// <summary>
        /// A test for SortMax with nested array is null.
        /// </summary>
        [Test]
        public void SortMax_NestedArrayIsNull_ThrowsArgumentNullException()
        {
            int[][] jaggedArray = new int[][]
            {
               null,
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortMax(jaggedArray));
        }

        /// <summary>
        /// A test for SortMin with nested array is null.
        /// </summary>
        [Test]
        public void SortMin_NestedArrayIsNull_ThrowsArgumentNullException()
        {
            int[][] jaggedArray = new int[][]
            {
               null,
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentNullException>(() => BubbleSort.SortMin(jaggedArray));
        }

        /// <summary>
        /// A test for SortSum with nested array is empty.
        /// </summary>
        [Test]
        public void SortSum_NestedArrayIsEmpty_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][]
            {
               new int[] { },
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentException>(() => BubbleSort.SortSum(jaggedArray));
        }

        /// <summary>
        /// A test for SortMax with nested array is empty.
        /// </summary>
        [Test]
        public void SortMax_NestedArrayIsEmpty_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][]
            {
               new int[] { },
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentException>(() => BubbleSort.SortMax(jaggedArray));
        }

        /// <summary>
        /// A test for SortMin with nested array is empty.
        /// </summary>
        [Test]
        public void SortMin_NestedArrayIsEmpty_ThrowsArgumentException()
        {
            int[][] jaggedArray = new int[][]
            {
               new int[] { },
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentException>(() => BubbleSort.SortMin(jaggedArray));
        }
    }
}
