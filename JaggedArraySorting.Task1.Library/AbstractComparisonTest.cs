using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorting.Task1.Library
{
    abstract class AbstractComparisonTest
    {
        public bool ascending = true;
        public abstract int GetTarget(int[] row);
    }
}
