using System;

namespace BinarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int[] lost = { 4, 8, 15, 16, 23, 42 };

			//Console.WriteLine(BinarySearchIterative(lost, 15));
			Console.WriteLine(BinarySearchRecursive(lost, 15));

		}

		/// <summary>
		/// Iteratively get index from a sorted array using binary search
		/// </summary>
		/// <param name="binaryArray">sorted binary array</param>
		/// <param name="value">value to search for</param>
		/// <returns>the index of the array</returns>
		static int BinarySearchIterative(int[] binaryArray, int value)
		{
			int minimum = 0;
			int last = binaryArray.Length - 1;

			while (minimum <= last)
			{
				//recalculate the middle portion
				int middle = (minimum + last) / 2;

				if (value > binaryArray[middle])
				{
					// if value is larger than the middle, then we increase
					// minimum number to be one larger than the middle
					minimum += middle++;

				}
				else if (value < binaryArray[middle])
				{
					// if the value is less than the middle, then place the last position
					// to one minus the middle index. 
					last = middle--;
				}
				else
				{
					// return the middle index + 1 to get the actual index number
					return middle;
				}
			}

			return -1;
		}

		/// <summary>
		/// Recursive approach to binary search of a sorted array
		/// </summary>
		/// <param name="binaryArray">sorted binary array</param>
		/// <param name="value">value to search for</param>
		/// <returns></returns>
		static int BinarySearchRecursive(int[] binaryArray, int value)
		{
			int index = BinarySearchRecursive(binaryArray, value, 0, binaryArray.Length);
			return index;
		}

		/// <summary>
		/// Recursive helper method
		/// </summary>
		/// <param name="binaryArray">current binary array that is being searched</param>
		/// <param name="value">value to search for</param>
		/// <param name="min">lowest index to search</param>
		/// <param name="max">largest index to search</param>
		/// <returns></returns>
		static int BinarySearchRecursive(int[] binaryArray, int value, int min, int max)
		{
			int midpoint = (min + max) / 2;

			// base case
			if (min > max)
			{
				return -1;
			}

			if (binaryArray[midpoint] > value)
			{
				return BinarySearchRecursive(binaryArray, value, min, midpoint - 1);
			}
			else if (binaryArray[midpoint] < value)
			{
				return BinarySearchRecursive(binaryArray, value, midpoint + 1, max);
			}
			else
			{
				return midpoint;

			}
		}
	}
}
