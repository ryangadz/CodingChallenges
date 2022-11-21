using System;
using System.Collections.Generic;

public class Program2 {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		// Write your code here.
        int aL = array.Count;
        int seqL = sequence.Count; 
        int ptr = 0; 
        if (seqL > aL)
            return false; 
        for (int i = 0; i < aL; i++)
        {
            if (array[i] == sequence[ptr])
            {
                ptr++; 
                if (ptr >= seqL)
                    return true; 
            }
        }
		return false;
	}
}
