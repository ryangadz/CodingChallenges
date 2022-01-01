using System;
using System.Collections.Generic;

public class Program {
	public static List<int> MoveElementToEnd(List<int> array, int toMove) {
		// Write your code here.
		int length = array.Count - 1; 
		int end = length;
		int i = 0; 
		while (i < end)
		{
			if (array[i] == toMove)
			{
				if (array[i] != array[end])
				{
					int temp = array[i]; 
					array[i] = array[end]; 
					array[end] = temp;
				}
				else end--; 
			}
			else i++; 
		}
		return array;
	}
}
