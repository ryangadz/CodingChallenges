using System;
using System.Collections.Generic;

public class Program {
	// Tip: You can use `el is IList<object>` to check whether an item is a list or
	// an integer.
	public static int ProductSum(List<object> array) {
		// Write your code here.
		int multiplier = 1; 
		return ProductSumRec(array, multiplier);
	}
	
	public static int ProductSumRec(List<object> array, int multiplier)
	{
		int sum = 0; 
		foreach (object obj in array)
		{
			if (obj is IList<object>)
				sum += ProductSumRec((List<object>)obj, multiplier + 1); 
			else sum += (int)obj; 
		}
		return sum * multiplier; 
	}
}
