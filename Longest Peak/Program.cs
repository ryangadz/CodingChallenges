using System;
using System.Collections.Generic; 

public class Program {
	public static int LongestPeak(int[] array) {
		// Write your code here.
		//List<int> longestPeak = new List<int>();
		List<int> peakIndices = new List<int>(); 
		int longestPeak = 0; 
		int length = array.Length - 1;
		for (int i = 1; i <= length - 1 ; i++)
		{
			if (array[i] > array[i-1] && array[i] > array[i+1])
			{
				//peak found
				peakIndices.Add(i); 
				Console.WriteLine("peakFound!"); 
			}
		}
		//if at least one peak set longest to 3; 
		if (peakIndices.Count > 0)
			longestPeak = 3; 
		
		//loop through all the peaks to find longest
		foreach(int i in peakIndices)
		{
			//Console.WriteLine(i); 
			int j = 1; 
			int k = 1; 
			int tempPeak = 3; 
			while (i-j-1 >= 0 && array[i-j] > array[i-j-1])
			{
				j++; 
				tempPeak++; 
				Console.WriteLine("j = " + j);
			}
			while (i+k+1 <= length && array[i+k] > array[i+k+1])
			{
				k++; 
				tempPeak++; 
				Console.WriteLine("k = " + k);
			}
			if (tempPeak > longestPeak) //i put a semicolon here and took 20 min to debug
				longestPeak = tempPeak; 
		}
		return longestPeak;
	}
}