using System;

public class Program2 {
	public static bool IsMonotonic(int[] array) {
		// Write your code here.
		bool isDecreasing = true; 
		bool isIncreasing = true; 
		int len = array.Length -1; 
		for (int i = 0; i < len; i++)
		{
			if (array[i] < array[i+1])
				isDecreasing = false;
			if (array[i] > array[i+1])
				isIncreasing = false; 
		}
		return isIncreasing || isDecreasing;
	}
}
