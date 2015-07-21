using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    class ExplorerSum : IRowExplorer
    {
        public int Explore(int[] row)
        {
            int targetSum=0;
            for (int i = 0; i < row.Length; i++)
            {
                targetSum += row[i];
            }
            return targetSum;    

        }
    }
}
