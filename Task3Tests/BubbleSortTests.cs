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
        [TestCaseSource(nameof(ValidTestCasesNull))]
        public void Sort_JaggedArray_SortedJaggedArray(IComparer<int[]> icomp, int[][] jArray, int[][] expected)
        {
            //act
            BubbleSort.Sort(jArray, icomp);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for Sort() with valid data. Delegate parameter.
        /// </summary>
        [Test, TestCaseSource(nameof(ValidTestCasesDelegate))]
        [TestCaseSource(nameof(ValidTestCasesNullDelegate))]
        public void Sort_JaggedArrayDelegate_SortedJaggedArray(Func<int[], int[], int> sortingFunction, int[][] jArray, int[][] expected)
        {
            //act
            BubbleSort.Sort(jArray, sortingFunction);
            //assert
            Assert.AreEqual(expected, jArray);
        }

        /// <summary>
        /// A test for Sort with null parameter.
        /// </summary>
        [Test,TestCaseSource(nameof(ExceptionsTestCases))]
        public void Sort_ArrayIsNull_ThrowsArgumentNullException(IComparer<int[]> icomp)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(null, icomp));
        }

        /// <summary>
        /// A test for Sort using delegete with null parameter. 
        /// </summary>
        [Test, TestCaseSource(nameof(ExceptionsTestCasesDelegate))]
        public void Sort_ArrayIsNullDelegate_ThrowsArgumentNullException(Func<int[], int[], int> sortingFunction)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(null, sortingFunction));
        }

        /// <summary>
        /// A test for Sort with null parameter.
        /// </summary>
        public void Sort_ICompIsNull_ThrowsArgumentNullException()
        {
            int[][] jaggedArray = new int[][] { new int[] { 1,2,3}, new int[] { 1,2,3} };
            IComparer<int[]> icomp = null;
            Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(jaggedArray, icomp));
        }

        /// <summary>
        /// A test for Sort using delegate with null parameter.
        /// </summary>
        public void Sort_ICompIsNullDelegate_ThrowsArgumentNullException()
        {
            int[][] jaggedArray = new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };
            Func<int[], int[], int> sortingFunction = null;
            Assert.Throws<ArgumentNullException>(() => BubbleSort.Sort(jaggedArray, sortingFunction));
        }

        /// <summary>
        /// A test for Sort with empty array.
        /// </summary>
        [Test, TestCaseSource(nameof(ExceptionsTestCases))]
        public void Sort_EmptyArray_ThrowsArgumentException(IComparer<int[]> icomp)
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(() => BubbleSort.Sort(jaggedArray, icomp));
        }

        /// <summary>
        /// A test for Sort with empty array.
        /// </summary>
        [Test, TestCaseSource(nameof(ExceptionsTestCasesDelegate))]
        public void Sort_EmptyArrayDelegate_ThrowsArgumentException(Func<int[], int[], int> sortingFunction)
        {
            int[][] jaggedArray = new int[][] { };
            Assert.Throws<ArgumentException>(() => BubbleSort.Sort(jaggedArray, sortingFunction));
        }

        static SortBySumAscending sortBySumAscending = new SortBySumAscending();
        static SortBySumDescending sortBySumdesc = new SortBySumDescending();
        static SortByMaxAscending sortByMaxAscending = new SortByMaxAscending();
        static SortByMaxDescending sortByMaxDescending = new SortByMaxDescending();

        static Func<int[], int[], int> sortBySumAscendingDelegate = sortBySumAscending.Compare;
        static Func<int[], int[], int> sortBySumdescDelegate = sortBySumdesc.Compare;
        static Func<int[], int[], int> sortByMaxAscendingDelegate = sortByMaxAscending.Compare;
        static Func<int[], int[], int> sortByMaxDescendingDelegate = sortByMaxDescending.Compare;

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

        static int[][] jaggedArray = new int[][]
            {
               null,
               new int[] { 1, 2, 3},
               new int[] { }
            };

        static int[][] jaggedArrayAsc = new int[][]
            {
               null,
               new int[] { },
               new int[] { 1, 2, 3}
            };

        static int[][] jaggedArrayDesc = new int[][]
            {
               new int[] { 1, 2, 3},
               new int[] { },
               null
            };

        /// <summary>
        /// Data for Sort_JaggedArray_SortedJaggedArray() when nested array is null.
        /// </summary>
        static IEnumerable ValidTestCasesNull
        {
            get
            {
                yield return new TestCaseData(new SortBySumAscending(), jaggedArray, jaggedArrayAsc);
                yield return new TestCaseData(new SortBySumDescending(), jaggedArray, jaggedArrayDesc);
                yield return new TestCaseData(new SortByMaxAscending(), jaggedArray, jaggedArrayAsc);
                yield return new TestCaseData(new SortByMaxDescending(), jaggedArray, jaggedArrayDesc);
            }
        }

        /// <summary>
        /// Data for Sort_JaggedArrayDelegate_SortedJaggedArray() when nested array is null.
        /// </summary>
        static IEnumerable ValidTestCasesNullDelegate
        {
            get
            {
                yield return new TestCaseData(sortBySumAscendingDelegate, jaggedArray, jaggedArrayAsc);
                yield return new TestCaseData(sortBySumdescDelegate, jaggedArray, jaggedArrayDesc);
                yield return new TestCaseData(sortByMaxAscendingDelegate, jaggedArray, jaggedArrayAsc);
                yield return new TestCaseData(sortByMaxDescendingDelegate, jaggedArray, jaggedArrayDesc);
            }
        }

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
        /// Data for Sort_JaggedArrayDelegate_SortedJaggedArray().
        /// </summary>
        static IEnumerable ValidTestCasesDelegate
        {
            get
            {
                yield return new TestCaseData(sortBySumAscendingDelegate, jArray, expectedAsc);
                yield return new TestCaseData(sortBySumdescDelegate, jArray, expectedDesc);
                yield return new TestCaseData(sortByMaxAscendingDelegate, jArray, expectedAsc);
                yield return new TestCaseData(sortByMaxDescendingDelegate, jArray, expectedDesc);
            }
        }

        static Func<int[], int[], int>[] ExceptionsTestCasesDelegate =
{
             sortBySumAscendingDelegate,
             sortBySumdescDelegate,
             sortByMaxAscendingDelegate,
             sortByMaxDescendingDelegate
    };

        /// <summary>
        /// Data for exception tests. 
        /// </summary>
        static IComparer<int[]>[] ExceptionsTestCases =
        {
             new SortBySumAscending(),
             new SortBySumDescending(),
             new SortByMaxAscending(),
             new SortByMaxDescending()
        };

    }
    #region

    public class SortBySumAscending : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray,null)) return -1;
            if (ReferenceEquals(secondArray, null)) return 1;
            if (firstArray.Length == 0) return -1;
            if (secondArray.Length == 0) return 1;
            return firstArray.Sum() - secondArray.Sum();
        }
    }

    public class SortBySumDescending : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return 1;
            if (ReferenceEquals(secondArray, null)) return -1;
            if (firstArray.Length == 0) return 1;
            if (secondArray.Length == 0) return -1;
            return secondArray.Sum() - firstArray.Sum();
        }
    }

    public class SortByMaxAscending : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return -1;
            if (ReferenceEquals(secondArray, null)) return 1;
            if (firstArray.Length == 0) return -1;
            if (secondArray.Length == 0) return 1;
            return firstArray.Max() - secondArray.Max();
        }
    }

    public class SortByMaxDescending : IComparer<int[]>
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
            if (ReferenceEquals(firstArray, null)) return 1;
            if (ReferenceEquals(secondArray, null)) return -1;
            if (firstArray.Length == 0) return 1;
            if (secondArray.Length == 0) return -1;
            return secondArray.Max() - firstArray.Max();
        }
    }
    #endregion
}
