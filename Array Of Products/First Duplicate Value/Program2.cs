using System.Collections.Generic;
using System;


public class Program2 {

	public int FirstDuplicateValue(int[] array) {
		// Write your code here.
		int length = array.Length;
		for (int i = 0; i < length; i++)
		{
			int index = Math.Abs(array[i])-1; 
			if (array[index] > 0)
				array[index] *= -1; 
			else return Math.Abs(array[i]); 
		}
		return -1;
	}
}

