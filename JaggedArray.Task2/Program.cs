using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[5][]{
                new int[5] { 1, 3, 5, 7, 9 },
                new int[4] { 2, 4, 6, 8 },
                new int[5] { 3, 16, 1, 7, 3 },
                new int[6] { 1, 3, 6, 11, 5, 10 },
                new int[3] { 8, 13, 6}};
            Console.WriteLine("В порядке возрастания максимальных элементов строк матрицы:");
            JaggedArraySorter jas1 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerMax(), true);
            jas1.Print();
            
            Console.WriteLine("В порядке убывания максимальных элементов строк матрицы:");
            JaggedArraySorter jas2 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerMax(), false);
            jas2.Print();

            Console.WriteLine("В порядке возрастания минимальных элементов строк матрицы:");
            JaggedArraySorter jas3 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerMin(), true);
            jas3.Print();

            Console.WriteLine("В порядке убывания минимальных элементов строк матрицы:");
            JaggedArraySorter jas4 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerMin(), false);
            jas4.Print();

            Console.WriteLine("В порядке возрастания сумм элементов строк матрицы:");
            JaggedArraySorter jas5 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerSum(), true);
            jas5.Print();

            Console.WriteLine("В порядке убывания сумм элементов строк матрицы:");
            JaggedArraySorter jas6 = new JaggedArraySorter(array, new BubbleSort(), new ExplorerSum(), false);
            jas6.Print();

            



        }
    }
}
