using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9,81,27};

            int a = FindGCDByStein(array);

            Console.WriteLine(a);
            Console.ReadLine();

        }

        public static int FindGCDByStein(params int[] array)
        {
            int result = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (result == 0) result = array[i];
                if (array[i] == 0) result = result;
                if (result == array[i]) result = result;
                if ((result % 2 == 0) && (array[i] % 2 == 0)) result = 2 * FindGCDByStein(result / 2, array[i] / 2);
                if ((result % 2 == 0) && (array[i] % 2 != 0)) result = FindGCDByStein(result / 2, array[i]);
                if ((result % 2 != 0) && (array[i] % 2 == 0)) result = FindGCDByStein(result, array[i] / 2);
                result = FindGCDByStein(array[i], Math.Abs(result - array[i]));
            }

            return result;
        }
    }
}
