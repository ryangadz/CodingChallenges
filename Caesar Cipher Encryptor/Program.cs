using System;

public class Program {
	public static string CaesarCypherEncryptor(string str, int key) {
		// Write your code here.

		int length = str.Length; 
		char[] charArray = new char[length]; 
		for (int i = 0; i < length; i++)
		{
			charArray[i] =  (char)((-97 + str[i] + key)%26 + 97);
		}		
		return new string(charArray);
	}
}
