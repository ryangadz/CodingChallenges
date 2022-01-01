using System;

public class Program {
	public static bool IsMonotonic(int[] array) {
		// Write your code here.
		int length = array.Length - 1;
		int pursue = 0; //0->unsure, 1->increase, -1->decrease
		if (array.Length == 0 || array.Length == 1)
			return true; 	
		for (int i = 0; i < length; i++ )
		{
			if (array[i] == array[i+1]) //equal
				continue; 
			else if (array[i] > array[i+1]) // decreasing
			{
				if (pursue == 1)
				 return false; 
				if (pursue == 0)
				{
					pursue = -1;
					continue; 
				}
			}
			else //if (array[i] < array[i+1]) increaseing
			{
				if (pursue == -1)
				 return false; 
				if (pursue == 0)
				{
					pursue = 1;
					continue; 
				}
			}
			
		}
			return true; 
	}
}
