using System;
using System.Collections.Generic; 

public class Program {

	public int[][] MergeOverlappingIntervals(int[][] intervals) {
		// Write your code here.
	//	Array.Sort(intervals[0] ); 
		Array.Sort(intervals, (x,y) => x[0].CompareTo(y[0])); 
		List<int[]> merged = new List<int[]>(); 
	//	foreach(int[] p in intervals)
	//		Console.WriteLine("[" + p[0] + "," + p[1] + "]"); 
		int[] currPair = intervals[0]; 
		int highest = currPair[1]; 
		foreach(int[] nextPair in intervals)
		{
			
			if (currPair[1] >= nextPair[0])
			{ //merge
				if (highest < nextPair[1])
				{
					currPair[1] = nextPair[1];
					highest = nextPair[1]; 
				}

			}
			else 
			{
				merged.Add(currPair); 
				currPair = nextPair; 
			}

		}
		merged.Add(currPair); 
		return merged.ToArray();
	}
}

