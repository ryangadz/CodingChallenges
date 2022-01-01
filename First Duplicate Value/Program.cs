using System.Collections.Generic;
using System;


public class Program {

	public int FirstDuplicateValue(int[] array) {
		// Write your code here.
		Dictionary<int, int> dups = new Dictionary<int, int>(); 
		int length = array.Length;
		for (int i = 0; i < length; i++)
		{
			if (dups.ContainsKey(array[i]))
				return array[i]; 
			else dups[array[i]] = 0; 
		}
		return -1;
	}
}

