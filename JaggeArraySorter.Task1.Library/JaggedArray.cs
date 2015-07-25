using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggeArraySorter.Task1.Library
{   
    public static class JaggedArray
    {
        public static void Sort<T>(T[][] jaggedArray, IRowComparer<T[]> comparer)
        {
            if (jaggedArray == null)
            {
                throw new ArgumentException(string.Format("Expecting jaggedArray to be {0}[][]", typeof(T).GetType().Name));
            }
            BubbleSort<T>(ref jaggedArray, comparer);
        }

        private static void BubbleSort<T>(ref T[][] jaggedArray, IRowComparer<T[]> comparer)
        {
            for (int j = 0; j < jaggedArray.Length - 1; j++)
            {
                for (int i = 0; i < jaggedArray.Length - j - 1; i++)
                {
                    if (comparer.Compare(jaggedArray[i], jaggedArray[i + 1]) == 1)
                    {
                        Swap<T[]>(ref jaggedArray[i], ref jaggedArray[i + 1]);
                    }
                }
            }
        }

        private static void Swap<T>(ref T left, ref T right)
        {
            T temp;
            temp = left;
            left = right;
            right = temp;
        }
    }
}
