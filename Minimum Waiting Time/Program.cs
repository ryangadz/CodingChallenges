using System;


public class Program {

	public int MinimumWaitingTime(int[] queries) {
		// Write your code here.
		int addedWaits = 0;
		int totalWaits = 0; 
		Array.Sort(queries); 
		
		int length = queries.Length -1;
		
		for (int i = 0; i < length; i++)
		{
			totalWaits += queries[i]; 
			addedWaits += totalWaits ; 
		}
		return addedWaits;
	}
}

