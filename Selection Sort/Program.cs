using System;

public class Program {
	public static int[] SelectionSort(int[] array) {
		// Write your code here.
		int length = array.Length-1; 
		int smallestIndex; 
		for (int i = 0; i < length; i++)
		{
			smallestIndex = i; 
			for (int j = i + 1; j <= length; j++)
			{
				if (array[j] <= array[smallestIndex])
				{
					smallestIndex = j; 
				}

			}
			int temp = array[smallestIndex]; 
			array[smallestIndex] = array[i]; 
			array[i] = temp; 
		}
		return array;
	}
}
