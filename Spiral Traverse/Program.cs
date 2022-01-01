using System;
using System.Collections.Generic;

public class Program {
	public static List<int> SpiralTraverse(int[,] array) {
		// Write your code here.
		int startingRow = 0;
		int startingCol = 0;
		int endingRow = array.GetLength(0) - 1; 
		int endingCol = array.GetLength(1) - 1;
		List<int> output = new List<int>(); 
		while (startingRow <= endingRow && startingCol <= endingCol)
		{
			for (int i = startingCol; i <= endingCol; i++)
				output.Add(array[startingRow, i]); 
			for (int i = startingRow + 1; i <= endingRow; i++)
				output.Add(array[i, endingCol]); 
			for (int i = endingCol - 1; i >= startingCol; i--)
			{
				if (startingRow == endingRow) break; 
				output.Add(array[endingRow, i]);
			}
			for (int i = endingRow - 1; i > startingRow; i--)
			{
				if (startingCol == endingCol) break; 
				output.Add(array[i, startingCol]); 	
			}

			
				
			startingRow++;
			startingCol++;
			endingRow--; 
			endingCol--;
		}
		
		return output;
	}
}
