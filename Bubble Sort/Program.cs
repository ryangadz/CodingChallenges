using System;

public class Program {
	public static int[] BubbleSort(int[] array) {
		// Write your code here.
	//	bool isSorted = false; 

		int length = array.Length - 1; 
		int swapCount = length;
		int passes = 0; 
		while (swapCount != 0)
		{
			swapCount = 0; 
			for (int i = 0; i < length - passes; i++)
			{
				if (array[i] > array[i+1])
				{ 
					int temp = array[i+1]; 
					array[i+1] = array[i]; 
					array[i] = temp; 
					swapCount ++; 
				}			
			}
			passes++; 
		}
		return array;
	}
}
