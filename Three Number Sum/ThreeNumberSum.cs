using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		// Write your code here.
		List<int[]> outList = new List<int[]>(); 
		Array.Sort(array); 
		int lengthM2 = array.Length - 2; 
		for (int i = 0; i < lengthM2 ; i++)
		{
			int left = i + 1; 
			int right = lengthM2 + 1; 
			while (left < right)
			{
				int currSum = array[i] + array[left] + array[right]; 
				if (currSum == targetSum)
				{
					int[] currNums = new int[3]{array[i],array[left], array[right]}; 
					outList.Add(currNums); 
					left++; 
					right--; 
				}
				else if (currSum > targetSum)
					right--; 
				else left++; 
			}
		}

		
		return outList;
	}
	
	
}