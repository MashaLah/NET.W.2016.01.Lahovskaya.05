using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;
using System.Collections;

namespace Task3Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        /// <summary>
        /// A test for Sort() with valid data.
        /// </summary>
        [Test,TestCaseSource(nameof(ValidTestCases))]
        public void Sort_JaggedArray_SortedJaggedArray(IComp icomp, int[][] jArray, int[][] expected)
        {
            //act
            BubbleSort.Sort(jArray, icomp);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for Sort with null parameter.
        /// </summary>
        [Test,TestCaseSource(nameof(ExceptionsTestCases))]
        public void Sort_ArrayIsNull_ThrowsArgumentNullException(IComp icomp)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(null, icomp));
        }

        /// <summary>
        /// A test for Sort with empty array.
        /// </summary>
        [Test, TestCaseSource(nameof(ExceptionsTestCases))]
        public void Sort_EmptyArray_ThrowsArgumentException(IComp icomp)
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(() => BubbleSort.Sort(jaggedArray, icomp));
        }

        /// <summary>
        /// A test for Sort with nested array is null.
        /// </summary>
        //[Test, TestCaseSource(nameof(ExceptionsTestCases))]
        //public void Sort_NestedArrayIsNull_ThrowsArgumentNullException(IComp icomp)
        //{
        //    int[][] jaggedArray = new int[][]
        //    {
        //       null,
        //       new int[] { 1, 2, 3}
        //    };
        //    Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(jaggedArray, icomp));
        //}

        /// <summary>
        /// A test for Sort with nested array is empty.
        /// </summary>
        [Test, TestCaseSource(nameof(ExceptionsTestCases))]
        public void Sort_NestedArrayIsEmpty_ThrowsArgumentException(IComp icomp)
        {
            int[][] jaggedArray = new int[][]
            {
               new int[] { },
               new int[] { 1, 2, 3}
            };
            Assert.Throws<ArgumentException>(() => BubbleSort.Sort(jaggedArray, icomp));
        }

        static int[][] jArray =
        {
                    new int[] {-1},
                    new int[] {3, 3, 5, 6, 0},
                    new int[] {-1, 2, 3}
                };

        static int[][] expectedAsc =
        {
                    new int[] {-1},
                    new int[] {-1, 2, 3},
                    new int[] {3, 3, 5, 6, 0}
                };

        static int[][] expectedDesc =
        {
                    new int[] { 3, 3, 5, 6, 0 },
                    new int[] { -1, 2, 3 },
                    new int[] { -1 }
                };

        /// <summary>
        /// Data for Sort_JaggedArray_SortedJaggedArray().
        /// </summary>
        static IEnumerable ValidTestCases
        {
            get
            {
                yield return new TestCaseData(new SortBySumAscending(), jArray, expectedAsc);
                yield return new TestCaseData(new SortBySumDescending(), jArray, expectedDesc);
                yield return new TestCaseData(new SortByMaxAscending(), jArray, expectedAsc);
                yield return new TestCaseData(new SortByMaxDescending(), jArray, expectedDesc);
            }
        }

        /// <summary>
        /// Data for exception tests. 
        /// </summary>
        static IComp[] ExceptionsTestCases =
        {
             new SortBySumAscending(),
             new SortBySumDescending(),
             new SortByMaxAscending(),
             new SortByMaxAscending()
        };

    }
    #region

    public class SortBySumAscending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray,null)) return -1;
            if (ReferenceEquals(secondArray, null)) return 1;
            return firstArray.Sum() - secondArray.Sum();
        }
    }

    public class SortBySumDescending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return 1;
            if (ReferenceEquals(secondArray, null)) return -1;
            return secondArray.Sum() - firstArray.Sum();
        }
    }

    public class SortByMaxAscending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return -1;
            if (ReferenceEquals(secondArray, null)) return 1;
            return firstArray.Max() - secondArray.Max();
        }
    }

    public class SortByMaxDescending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return -1;
            if (ReferenceEquals(secondArray, null)) return 1;
            return secondArray.Max() - firstArray.Max();
        }
    }
    #endregion
}
