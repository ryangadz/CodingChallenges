using System;
using System.Collections.Generic; 

public class Program {

	public int FirstNonRepeatingCharacter(string str) {
		// Write your code here.
		Dictionary<char, int> table = new Dictionary<char, int>(); 
		int length = str.Length; 
		foreach(char c in str)
		{
			table[c] = table.GetValueOrDefault(c, 0) + 1; 
		}
		
		for (int i = 0; i < length; i++)
		{
			char c = str[i]; 
			if(table[c] == 1)
				return i; 
		}
		
		return -1;
	}
}
