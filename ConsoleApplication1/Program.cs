using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggedArraySorter.Task1.Library;

namespace ConsoleApplication1
{
    class Program
    {
        static void PrintToConsole(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
			{
                if (jaggedArray[i] == null)
                {
                    Console.WriteLine();
                    continue;
                }
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        Console.Write(jaggedArray[i][j] + "\t");
                    }
                    Console.WriteLine();
                
			}
            Console.WriteLine("----------------------------------");
        }

        static int[][] CreateRandomJaggedArray(int minRowsCount, int maxRowsCount, int minColsCount, int maxColsCount, int minValue, int maxValue)
        {
            Random random = new Random();
            int rowsCount = random.Next(minRowsCount,maxRowsCount);
            
            int[][] jaggedArray = new int[rowsCount][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int colsCount = random.Next(minColsCount, maxColsCount);
                jaggedArray[i] = new int[colsCount];

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    int value = random.Next(minValue, maxValue);
                    jaggedArray[i][j]= value;
                    System.Threading.Thread.Sleep(1);
                }
            }
            return jaggedArray;
        }
      
        static void Main(string[] args)
        {
            //int[][] jaggedArray = CreateRandomJaggedArray(5, 6, 0, 4, -10, 10);
            //jaggedArray[0] = new int[0];
            int[][] jaggedArray = new int[][]{
                new int[]{1, 3, -6, 8, 9},
                new int[]{-2, 4, 3, 1},
                new int[0],
                null,
                null,
                new int[]{1, -3, 6, -8},
                new int[0],
                null,
                new int[]{-15, 5, 4, 17},
            };
            
            PrintToConsole(jaggedArray);

            JaggedArray.Sort<int>(jaggedArray, new AscendingSumComparer());
            PrintToConsole(jaggedArray);
        
            Console.ReadLine();
        }

        public class AscendingSumComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                
                if ((first == null)||(first.Length==0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return -1;
                }
                if ((second == null) || (second.Length == 0))
                    return 1;
             

                int firstSum = Sum(first);
                int secondSum = Sum(second);

                if (firstSum == secondSum)
                    return 0;
                if (firstSum < secondSum)
                    return -1;
                else return 1;
            } 
        }

        public class DescendingSumComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return 1;
                }
                if ((second == null) || (second.Length == 0))
                    return -1;

                int firstSum = Sum(first);
                int secondSum = Sum(second);

                if (firstSum == secondSum)
                    return 0;
                if (firstSum < secondSum)
                    return 1;
                else return -1;
            }
        }

        private static int Sum(int[] row)
        {
            int sum = 0;
            for (int i = 0; i < row.Length; i++)
            {
                sum += row[i];
            }
            return sum;
        }


        public class AscendingMaxAbsValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return -1;
                }
                if ((second == null) || (second.Length == 0))
                    return 1;

                int maxAbsValueFirst = MaxAbsValue(first);
                int maxAbsValueSecond = MaxAbsValue(second);

                if (maxAbsValueFirst == maxAbsValueSecond)
                    return 0;
                if (maxAbsValueFirst < maxAbsValueSecond)
                    return 1;
                else return -1;
            }    
        }

        public class DescendingMaxAbsValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return 1;
                }
                if ((second == null) || (second.Length == 0))
                    return -1;

                int maxAbsValueFirst = MaxAbsValue(first);
                int maxAbsValueSecond = MaxAbsValue(second);

                if (maxAbsValueFirst == maxAbsValueSecond)
                    return 0;
                if (maxAbsValueFirst < maxAbsValueSecond)
                    return 1;
                else return -1;
            }
        }

        private static int MaxAbsValue(int[] row)
        {
            int maxAbsValue = Math.Abs(row[0]);
            for (int i = 1; i < row.Length; i++)
            {
                if (maxAbsValue < Math.Abs(row[i]))
                    maxAbsValue = Math.Abs(row[i]);
            }
            return maxAbsValue;
        }


        public class AscendingMaxValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return -1;
                }
                if ((second == null) || (second.Length == 0))
                    return 1;

                int maxValueFirst = MaxValue(first);
                int maxValueSecond = MaxValue(second);

                if (maxValueFirst == maxValueSecond)
                    return 0;
                if (maxValueFirst < maxValueSecond)
                    return 1;
                else return -1;
            }
        }

        public class DescendingMaxValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return 1;
                }
                if ((second == null) || (second.Length == 0))
                    return -1;

                int maxValueFirst = MaxValue(first);
                int maxValueSecond = MaxValue(second);

                if (maxValueFirst == maxValueSecond)
                    return 0;
                if (maxValueFirst < maxValueSecond)
                    return 1;
                else return -1;
            }
        }

        private static int MaxValue(int[] row)
        {
            int maxValue = row[0];
            for (int i = 1; i < row.Length; i++)
            {
                if (maxValue < row[i])
                    maxValue = row[i];
            }
            return maxValue;
        }


        public class AscendingMinValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return -1;
                }
                if ((second == null) || (second.Length == 0))
                    return 1;

                int minValueFirst = MinValue(first);
                int minValueSecond = MinValue(second);

                if (minValueFirst == minValueSecond)
                    return 0;
                if (minValueFirst < minValueSecond)
                    return 1;
                else return -1;
            }
        }

        public class DescendingMinValueComparer : IRowComparer<int[]>
        {
            public int Compare(int[] first, int[] second)
            {
                if ((first == null) || (first.Length == 0))
                {
                    if ((second == null) || (second.Length == 0))
                        return 0;
                    else
                        return 1;
                }
                if ((second == null) || (second.Length == 0))
                    return -1;

                int minValueFirst = MinValue(first);
                int minValueSecond = MinValue(second);

                if (minValueFirst == minValueSecond)
                    return 0;
                if (minValueFirst < minValueSecond)
                    return 1;
                else return -1;
            }
        }

        private static int MinValue(int[] row)
        {
            int minValue = row[0];
            for (int i = 1; i < row.Length; i++)
            {
                if (minValue > row[i])
                    minValue = row[i];
            }
            return minValue;
        }

    }
}
