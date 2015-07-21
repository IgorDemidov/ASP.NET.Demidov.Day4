using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class JaggedArraySorter
    {
        
        public int[][] JaggetArray { get; private set; }
        private int[] rowsTargets;
        private IRowExplorer explorer;


        public JaggedArraySorter(int[][] arr, ISort sorting, IRowExplorer explorer, bool ascending)
        {            
            JaggetArray = arr;
            this.explorer = explorer;
            GetSortTargets();
            sorting.Sort(JaggetArray, rowsTargets, ascending);
        }

        public int[] GetSortTargets()
        {
            rowsTargets = new int[0];
            foreach (int[] item in JaggetArray)
            {
                Array.Resize<int>(ref rowsTargets, rowsTargets.Length + 1);
                rowsTargets[rowsTargets.Length - 1] = explorer.Explore(item); 
            }
            return rowsTargets;
        }

        public void Print()
        {
            for (int i = 0; i < JaggetArray.Length; i++)
            {
                Console.Write("Строка {0,2} ", i);

                for (int j = 0; j < JaggetArray[i].Length; j++)
                {
                    Console.Write("{0,3}", JaggetArray[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press button...");
            Console.ReadKey();
        }
   
       

    }
}
