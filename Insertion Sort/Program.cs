using System;

public class Program {
	public static int[] InsertionSort(int[] array) {
		// Write your code here.
		int index = 0; 
		int length = array.Length - 1; 
		for (int i = 0; i < length; i++)
		{
			index = i; 
			int next = array[i + 1]; 
			int compared = array[i]; 
			while (next < compared)
			{
				array[index] = array[index + 1]; 
				array[index + 1] = compared; 
				index--; 
				if (index < 0)
					break;
				compared = array[index];
			}
		}
		return array;
	}
}
