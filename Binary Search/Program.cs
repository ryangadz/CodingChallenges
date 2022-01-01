using System;

public class Program {
	public static int BinarySearch(int[] array, int target) {
		// Write your code here.
		int left = 0; 
		int right = array.Length - 1; 
		int middle = (left + right) / 2; 
		while (left <= right)
		{
			if (target == array[middle])
				return middle; 
			else if (target < array[middle])
				right = middle - 1; 
			else 
				left = middle + 1; 
			
			middle = (left + right) / 2; 
		}
		return -1;
	}
}
