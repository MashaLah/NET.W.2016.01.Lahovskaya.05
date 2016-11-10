using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Adapter:IComparer<int[]>
    {
        Func<int[],int[],int> sortingFunction;

        public Adapter(Func<int[], int[], int> sortingFunction)
        {
            this.sortingFunction = sortingFunction;
        }

        public int Compare(int[] firstArray, int[] secondArray)
        {
            return sortingFunction(firstArray,secondArray);
        }
    }
}
