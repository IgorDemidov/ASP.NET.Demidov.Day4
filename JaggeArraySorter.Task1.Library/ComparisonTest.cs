using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{
    abstract class AbstractComparisonTest
    {
        public bool ascending = true;

        protected abstract int Operation(int? pervios, int? next);

        public int?[] GetComparisonTargets(int[][] jaggedArray)
        {
            int?[] targets = new int?[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                targets[i] = GetRowTarget(jaggedArray[i]);
            }
            return targets;
        }

        private int? GetRowTarget(int[] row)
        {
            if ((row == null) || (row.Length == 0))
                return null;

            int? target = null;
            for (int i = 0; i < row.Length; i++)
            {
                if (target == null)
                    target = row[i];
                else
                    target = Operation(target, row[i]);
            }
            return target;
        }

        
        
    }
}
