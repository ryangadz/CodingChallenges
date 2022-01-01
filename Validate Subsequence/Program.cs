using System;
using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
		//bool isSeq = false; 
		int arrayLength = array.Count;
		int seqLength = sequence.Count; 
		if (arrayLength < seqLength)
			return false; 
		int currSeq = 0; 
		for (int i = 0; i < arrayLength && currSeq < seqLength; i++)
		{

				if (array[i] == sequence[currSeq])
				{
					currSeq++; 
				}

		}

		return currSeq == seqLength;
	}
}