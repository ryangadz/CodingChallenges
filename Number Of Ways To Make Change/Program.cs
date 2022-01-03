using System;

public class Program {
	public static int NumberOfWaysToMakeChange(int n, int[] denoms) {
		// Write your code here.
		//if (n == 0)
	//		return 1; 
		int num = n + 1; 
		int[] ways = new int[num + 1];
		ways[0] = 1; 
		int dIndex = 0; 
		int dLength = denoms.Length ; 
		while (dIndex < dLength && denoms[dIndex] <= n)
		{
			for (int i = 1; i < num; i++)
			{
				if (denoms[dIndex]  <= i )
				{
					ways[i] += ways[i - denoms[dIndex]]; 
				}
			}
			dIndex++; 
		}

		return ways[n];
	}
}
