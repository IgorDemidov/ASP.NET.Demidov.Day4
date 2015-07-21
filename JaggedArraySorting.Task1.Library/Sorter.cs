using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArraySorting.Task1.Library
{

    public static class Sorter
    {
        /*
        public static int[][] Sort()
        {
           
        }*/

        private static void BubbleSort(Dictionary<int, int[]> sortedRows, AbstractComparisonTest test)
        {
            

        
            
        }

        private static Dictionary<int, int[]> JuggedArrayToDictionary(int[][] juggedArray, AbstractComparisonTest test)
        {
            Dictionary<int, int[]> converted = new Dictionary<int, int[]>();

            for (int i = 0; i < juggedArray.Length; i++)
			{
                converted.Add(test.Target(juggedArray[i]),juggedArray[i]);
			}
           
            return converted;
        }

        private static int[][] CreateResultJuggedArray( Dictionary<int, int[]> dictionary, AbstractComparisonTest test)
        {
            int[][] result = new int[dictionary.Count][];
            foreach (int[] item in dictionary.Values)
	        {
                if (test.ascending)
                    result[i] = item; 		 
	        }

            
            return result;
        }

        
        


    }
}
