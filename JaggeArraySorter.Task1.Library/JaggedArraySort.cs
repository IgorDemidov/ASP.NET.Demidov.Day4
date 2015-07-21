using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggeArraySorter.Task1.Library
{   
    public static class JaggedArraySort
    {
        public static void SortRowsByMaxValue(ref int[][] jaggedArray)
        {
            MaxRowElementTest comparisonTest = new MaxRowElementTest();
            BubbleSort(ref jaggedArray, comparisonTest);
        }

        public static void SortRowsByMaxValue(ref int[][] jaggedArray, bool ascending)
        {
            MaxRowElementTest comparisonTest = new MaxRowElementTest();
            comparisonTest.Acsending = ascending;
            BubbleSort(ref jaggedArray, comparisonTest);
        }

        public static void SortRowsByMinValue(ref int[][] jaggedArray)
        {
            MinRowElementTest comparisonTest = new MinRowElementTest();
            BubbleSort(ref jaggedArray, comparisonTest);
        }

        public static void SortRowsByMinValue(ref int[][] jaggedArray, bool ascending)
        {
            MinRowElementTest comparisonTest = new MinRowElementTest();
            comparisonTest.Acsending = ascending;
            BubbleSort(ref jaggedArray, comparisonTest);
        }

        public static void SortRowsByValueSum(ref int[][] jaggedArray)
        {
            SumRowElementTest comparisonTest = new SumRowElementTest();
            BubbleSort(ref jaggedArray, comparisonTest);
        }

        public static void SortRowsByValueSum(ref int[][] jaggedArray, bool ascending)
        {
            SumRowElementTest comparisonTest = new SumRowElementTest();
            comparisonTest.Acsending = ascending;
            BubbleSort(ref jaggedArray, comparisonTest);
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
