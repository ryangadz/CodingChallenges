using System;

public class Program {

	public int[] SortedSquaredArray(int[] array) {
		// Write your code here.
		int length = array.Length; 
		for (int i = 0; i < length; i++)
		{
				int pow = (int)Math.Pow(array[i], 2); 
				array[i] = pow; 
		}
		Array.Sort(array); 
		return array;
	}
}

