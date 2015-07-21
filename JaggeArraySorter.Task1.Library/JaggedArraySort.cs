using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggeArraySorter.Task1.Library
{   
    static class JaggedArraySort
    {
        public static void SortRowsByMaxValue(ref int[][] jaggedArray)
        {
           MaxRowElementTest m = new MaxRowElementTest();
           BubbleSort(ref jaggedArray, m);
           AbstractComparisonTest k = m;
        }

        public static void SortRowsByMaxValue(ref int[][] jaggedArray, bool ascending)
        {

        }

        public static void SortRowsByMinValue(ref int[][] jaggedArray)
        {

        }

        public static void SortRowsByMinValue(ref int[][] jaggedArray, bool ascending)
        {

        }

        public static void SortRowsByValuesSum(ref int[][] jaggedArray)
        {

        }

        private static void BubbleSort(ref int[][] arr, AbstractComparisonTest comparisonTest)
        {
            int?[] targets = comparisonTest.GetComparisonTargets(arr);
            bool ascending = comparisonTest.Acsending;

            for (int j = 0; j < targets.Length - 1; j++)
            {
                for (int i = 0; i
                    < targets.Length - j - 1; i++)
                {
                    if (GetCurrentSortingNecessity(targets[i], targets[i + 1], ascending))
                    {
                        Swap<int?>(ref targets[i], ref targets[i + 1]);
                        Swap<int[]>(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
        }

        private static bool GetCurrentSortingNecessity(int? current, int? next, bool ascending)
        {
            return (current!=next)&&((current > next) == ascending);
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
