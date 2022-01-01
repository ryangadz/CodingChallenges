using System;

public class Program {
	public static int[] TwoNumberSum(int[] array, int targetSum) {
		// Write your code here.
		int length = array.Length; 

		int[] sums = new int[array.Length * array.Length]; 
		int count = 0; 
		for(int i = 0; i < length -1; i++)
		{
			for (int p = i + 1; p < length; p++)
			{
				int sum = array[i] + array[p]; 
				if (sum == targetSum)
				{
					sums[count] = array[i];
					sums[count+1] = array[p];
					count += 2; 
				}
			}
		}
		Array.Resize(ref sums, count); 
		return sums;
	}
}
