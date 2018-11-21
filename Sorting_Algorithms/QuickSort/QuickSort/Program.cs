using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted Array");
            Console.WriteLine("");

            int[] myArray = { 10, 80, 30, 90, 40, 50, 70 };
            for ( int i = 0; i < myArray.Length; i++ )
            {
                Console.Write(myArray[i] + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Begin Sorting");
            Console.WriteLine("");
            QuickSort(myArray, 0, myArray.Length - 1);

            Console.WriteLine("Sorted Array");
            Console.WriteLine("");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " " );
            }
            Console.WriteLine("");
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Partition the Algorithm
                int position = Partition(arr, left, right);
                // Sort the left
                QuickSort(arr, left, position - 1);
                // Sort the right
                QuickSort(arr, position + 1, right);

            }

        }

        static int Partition(int[] arr, int left, int right)
        {
            // set a pivot
            int pivot = arr[right];
            // get the index of the lower value
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }

            }

            Swap(arr, right, low + 1);

            Console.WriteLine(string.Join(",", arr));


            return low + 1;
        }

        static void Swap(int[] arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }

    }
}
