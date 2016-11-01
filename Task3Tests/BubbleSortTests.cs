﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task3;

namespace Task3Tests
{
    [TestFixture]
    public class BubbleSortTests
    {
        [Test]
        public void Sort_JaggedArray_SortedJaggedArray()
        {
            //arrange
            int[][] jArray =
            {
                new int[] {-1},
                new int[] {3, 3, 5, 6, 0},
                new int[] {1, 2, 3}
            };
            int[][] expected =
            {
                new int[] {-1},
                new int[] {1, 2, 3},
                new int[] {3, 3, 5, 6, 0}
            };
            IComp icomp = new SortBySumAscending();
            //act
            BubbleSort.Sort(jArray, icomp);
            //assert
            Assert.AreEqual(expected, jArray);
        }

    }

    public class SortBySumAscending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            return firstArray.Sum() - secondArray.Sum();
        }
    }

    public class SortBySumDescending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            return secondArray.Sum() - firstArray.Sum();
        }
    }

    public class SortByMaxAscending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            return firstArray.Max() - secondArray.Max();
        }
    }

    public class SortByMaxDescending : IComp
    {
        public int CompareTo(int[] firstArray, int[] secondArray)
        {
            return secondArray.Max() - firstArray.Max();
        }
    }
}
