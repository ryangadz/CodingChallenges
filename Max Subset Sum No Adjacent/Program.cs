using System;

public class Program {
	public static int MaxSubsetSumNoAdjacent(int[] array) {
		// Write your code here.
		int length = array.Length; 
		int[] maxSums = new int[length]; 
		if (length == 0)
			return 0; 
		if (length == 1)
			return array[0]; 
		maxSums[0] = array[0]; 
		maxSums[1] = Math.Max(array[0], array[1]); 
		if (length == 2)
			return maxSums[1]; 
		for (int i = 2; i < length; i++)
		{
			maxSums[i] = Math.Max(maxSums[i-1], maxSums[i-2] + array[i]); 
		}
		return maxSums[length - 1];
	}
}