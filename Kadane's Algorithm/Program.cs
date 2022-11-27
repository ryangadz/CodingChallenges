using System;

public class Program {
	public static int KadanesAlgorithm(int[] array) {
		// Write your code here.
        int length = array.Length; 
        int maxSum = array[0];
        int maxCur = maxSum;
        for(int i = 1; i < length; i++ )
        {
            maxCur = Math.Max(maxCur + array[i], array[i]);
            maxSum = Math.Max(maxSum, maxCur);                
        }
		return maxSum;
	}
}