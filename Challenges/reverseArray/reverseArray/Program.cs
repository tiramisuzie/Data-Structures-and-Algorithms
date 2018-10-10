using System;

namespace reverseArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string[] cats = { "Josie", "Belle", "Frodo", "Trinity", "Leia" };

			OutputArray(cats);
			Console.WriteLine("-----------");
			OutputArray(ArrayReverse(cats));
			Console.WriteLine("-------------");
			OutputArray(ReverseInPlace(cats));
		}

		/// <summary>
		/// Reverse an array with additional space and time
		/// </summary>
		/// <param name="myArray">string array to be reversed</param>
		/// <returns>Newly reversed array</returns>
		static string[] ReverseArray(string[] myArray)
		{
			Console.WriteLine("Array Reverse");
			string[] reversed = new string[myArray.Length];
			int counter = 0;

			for (int i = myArray.Length - 1; i >= 0; i--)
			{
				reversed[i] = myArray[counter++];
			}
			return reversed;
		}


		/// <summary>
		/// Reverse and array in place with better space/time
		/// </summary>
		/// <param name="myArray">string array to be reversed</param>
		/// <returns>the newly reversed array</returns>
		static string[] ReverseInPlace(string[] myArray)
		{
			Console.WriteLine("In Place");
			string temp;

			for (int i = 0; i < myArray.Length / 2; i++)
			{
				temp = myArray[myArray.Length - 1 - i];
				myArray[myArray.Length - 1 - i] = myArray[i];
				myArray[i] = temp;
			}

			return myArray;
		}

		/// <summary>
		/// Output the array to the console
		/// </summary>
		/// <param name="myArray">The string array to be outputted</param>
		static void OutputArray(string[] myArray)
		{
			for (int i = 0; i < myArray.Length; i++)
			{
				Console.WriteLine(myArray[i]);
			}
		}


	}
}
