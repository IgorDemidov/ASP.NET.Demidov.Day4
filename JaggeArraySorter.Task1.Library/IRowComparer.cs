using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorter.Task1.Library
{
    public interface IRowComparer<T>
    {
        int Compare(T first, T second);
    }
}
