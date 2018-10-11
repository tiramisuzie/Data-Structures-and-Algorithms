using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class ArrayBinarySearch
    {
        public int BinarySearch(int [] array, int searchKey)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            while (startIndex <= endIndex)
            {
                int midpoint = CalculateMidPoint(startIndex, endIndex);

                if (array[midpoint] == searchKey)
                {
                    return searchKey;
                }
                else if (array[midpoint] < searchKey)
                {
                    startIndex = midpoint + 1;
                }
                else
                {
                    endIndex = midpoint - 1;
                }
            }
            return -1;
        }
        
        public int CalculateMidPoint(int startIndex, int endIndex)
        {
            return (startIndex + endIndex) / 2;
        }
    }
    //{ 4, 8, 15, 16, 23, 42 } 23
    // 0 + 5 / 2 = 2
    // 3 + 5 / 2 = 4
}
