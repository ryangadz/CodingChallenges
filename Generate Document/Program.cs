using System;
using System.Collections.Generic; 

public class Program {

	public bool GenerateDocument(string characters, string document) {
		// Write your code here.
		if (document.Length == 0)
			return true; 
		if (document.Length > characters.Length)
			return false; 
		
		Dictionary<char, int> table = new Dictionary<char, int>();
		FillTableWithString(ref table, characters); 
		foreach(char c in document)
		{
			if (table.ContainsKey(c))
			{
				table[c] -= 1; 
				if (table[c] < 0) 
					return false; 
			}
			else return false; 

			
		}
		
		return true;
	}
	
	public static void FillTableWithString(ref Dictionary<char, int> t, string chars)
	{
		foreach(char c in chars)
		{
			if (!t.ContainsKey(c))
				t[c] = 1; 
			else t[c] += 1; 
		}
	}
}

