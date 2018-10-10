using System;

namespace arrayShift
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			int[] myArr = { 2, 4, 6, 8 };

			int[] result = InsertArrayShift(myArr, 5);

			for (int i = 0; i < result.Length; i++)
			{
				Console.Write($"{result[i]} ");
			}
		}

		/// <summary>
		/// Add an element to the middle of an array
		/// </summary>
		/// <param name="input">integer array</param>
		/// <param name="value">value to be added to middle</param>
		/// <returns>the new array with value in the middle</returns>
		static int[] InsertArrayShift(int[] input, int value)
		{
			int[] addedArr = new int[input.Length + 1];

			decimal middle = Math.Ceiling((decimal)(input.Length +1) / 2);
			int counter = 0;

			for (int i = 0; i < addedArr.Length; i++)
			{
				if (i == middle - 1)
				{
					addedArr[i] = value;
				}
				else
				{
					addedArr[i] = input[counter++];
				}

			}

			return addedArr;
		}
	}
}
