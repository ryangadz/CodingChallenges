using System;

public class Program {
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) {
		// Write your code here.
		Array.Sort(arrayOne); 
		Array.Sort(arrayTwo);
		int length1 = arrayOne.Length; 
		int length2 = arrayTwo.Length; 
		int i = 0; 
		int j = 0; 
		int[] output = new int[2]{arrayOne[i], arrayTwo[j]}; 

		int smallestDiff = int.MaxValue; 
		while(i < length1 && j < length2)
		{
			int diff; 
			diff = Math.Abs(arrayOne[i] - arrayTwo[j]); 
			if (diff == 0)
				return new int[]{arrayOne[i], arrayTwo[j]};
			if (diff < smallestDiff)
			{
				smallestDiff = diff; 
				output[0] = arrayOne[i];
				output[1] = arrayTwo[j]; 
			}
			if (arrayOne[i] < arrayTwo[j])
			{
				i++; 
			}
			else j++;
		}
		
		return output;
	}
}
