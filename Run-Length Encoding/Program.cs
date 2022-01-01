using System;
using System.Text; 

public class Program {
	public string RunLengthEncoding(string str) {
		// Write your code here.
		int currentRun = 1; 
		char currentChar = str[0]; 
		int length = str.Length - 1; 
		StringBuilder output = new StringBuilder(); 
		for (int i = 0; i < length; i++)
		{
			if (str[i] == str[i+1] && currentRun < 9)
			{
				currentRun++; 
			}
			else
			{			
				output.Append(currentRun);
				output.Append(currentChar); 
				currentChar = str[i+1]; 
				currentRun = 1; 
			}
			
		}
		output.Append(currentRun);
		output.Append(currentChar); 
		return output.ToString();
	}
}
