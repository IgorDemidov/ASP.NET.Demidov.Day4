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

        private static int[][] OderlyResultJuggedArray(Dictionary<int, int[]> dictionary, AbstractComparisonTest test)
        {
            int[][] result = new int[dictionary.Count][];
 
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (test.ascending)
                    result[i] = dictionary.ElementAt<KeyValuePair<int, int[]>>(i).Value;
                else
                    result[dictionary.Count-i-1] = dictionary.ElementAt<KeyValuePair<int, int[]>>(i).Value;
            }

            return result;
        }

        
        


    }
}
