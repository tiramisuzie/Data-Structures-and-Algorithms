using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class ArrayBinarySearch
    {
        public int BinarySearch(int[] array, int searchKey)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            while (startIndex <= endIndex)
            {
                // reCalculate midpoint for every loop
                int midpoint = (startIndex + endIndex) / 2;

                // if key is found return it
                if (array[midpoint] == searchKey)
                {
                    return searchKey;
                }
                // if key is greater than value at midpoint then search the right side of midpoint
                else if (array[midpoint] < searchKey)
                {
                    startIndex = midpoint + 1;
                }
                // if key is less than value at midpoint the search the left side of midpoint
                else
                {
                    endIndex = midpoint - 1;
                }
            }
            // key does not exist
            return -1;
        }
    }
}
