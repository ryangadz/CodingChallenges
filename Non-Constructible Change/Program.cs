using System;


public class Program {

	public int NonConstructibleChange(int[] coins) {
		// Write your code here.
		int minAmount = 0; 
		int change = 1; 
		int currSum = 0; 
		int length = coins.Length; 
		Array.Sort(coins); 
		for (int i = 0; i < length; i++)
		{
			currSum += coins[i]; 
			if (coins[i] > minAmount + 1)
				break; 
			else minAmount = currSum ; 
		}

		
		return minAmount +1;
	}
}

