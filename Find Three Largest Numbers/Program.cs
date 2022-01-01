using System;

public class Program {
	public static int[] FindThreeLargestNumbers(int[] array) {
		// Write your code here.
		int[] threeLargest = new int[3]{-2147483648, -2147483648, -2147483648}; 
		int length = array.Length; 
		for (int i = 0; i < length; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (array[i] > threeLargest[j])
				{
					if (j == 0)
					{
						threeLargest[2] = threeLargest[1];
						threeLargest[1] = threeLargest[0]; 
					}
					else if( j == 1)
					{
					threeLargest[2] = threeLargest[1];
					}
					threeLargest[j] = array[i];
					
					break; 
				}
			}

		}
		Array.Reverse(threeLargest); 
		return threeLargest;
	}
}
