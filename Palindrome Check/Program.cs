using System;

public class Program {
	public static bool IsPalindrome(string str) {
		// Write your code here.
		int left = 0; 
		int right = str.Length - 1;
		while(left < right)
		{
			if (str[left] != str[right])
				return false; 
			left++; 
			right--;
		}
		
		return true;
	}
}
