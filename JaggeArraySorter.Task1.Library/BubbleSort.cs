using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray.Task2
{   
    class BubbleSort: ISort
    {
        public void Sort(int[][] arr, int[] RowsTargets, bool ascending)
        {
            int targetTemp;
            int[] arrTemp;

            for (int j = 0; j < RowsTargets.Length - 1; j++)
            {
                for (int i = 0; i 
                    < RowsTargets.Length - j - 1; i++)
                {
                    if (((RowsTargets[i] > RowsTargets[i + 1])==ascending)&&(RowsTargets[i] != RowsTargets[i + 1]))
                    {
                        targetTemp = RowsTargets[i];
                        arrTemp=arr[i];
                        RowsTargets[i] = RowsTargets[i + 1];
                        arr[i] = arr[i+1];
                        RowsTargets[i + 1] = targetTemp;
                        arr[i + 1] = arrTemp;
                    }
                }
            }
         
           
        }
    }
}
