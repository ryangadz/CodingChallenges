using System;

public class Program {
	public static int MinNumberOfCoinsForChange(int n, int[] denoms) {
		// Write your code here.
		int[] targets = new int[n+1];

		Array.Fill(targets, Int32.MaxValue); 
		targets[0] = 0; 
		Array.Sort(denoms); 
		if (n == 0)
			return 0; 
		int dLength = denoms.Length; 
		int dIndex = 0; 
	//	int tIndex = 0; 
		int toCompare = 0; 
	//	int pickupIndex = 0; 
		while (dIndex < dLength && denoms[dIndex] <= n)
		{
			//for (int i = pickupIndex; i < n + 1; i++)
			for (int i = 0; i < n + 1; i++)
			{
				if (denoms[dIndex] <= i)
				{
					if (targets[i - denoms[dIndex]] == Int32.MaxValue)
						toCompare = targets[i - denoms[dIndex]]; 
					else
						toCompare = targets[i - denoms[dIndex]] + 1; 
					targets[i] = Math.Min(targets[i], toCompare); 							 
				}

			}

			dIndex++; 
		//	pickupIndex = denoms[dIndex]-1; 
		}
		if (targets[n] == Int32.MaxValue)
			return -1 ;
		else
			return targets[n];
	}
}