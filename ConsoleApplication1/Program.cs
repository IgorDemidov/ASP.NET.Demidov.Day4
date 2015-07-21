using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaggeArraySorter.Task1.Library;

namespace ConsoleApplication1
{
    class Program
    {
        static void PrintToConsole(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
			{
                for (int j = 0; j < jaggedArray[i].Length; j++)
			    {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
			} 
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
            int[][] jaggedArray = CreateRandomJaggedArray(5, 6, 4, 8, -10, 10);
            PrintToConsole(jaggedArray);
            Console.ReadLine();

            

        }
    }
}
