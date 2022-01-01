using System;

public class Program {
	public int[] ArrayOfProducts(int[] array) {
		// Write your code here.
		int length = array.Length -1; 
		int[] pArray = new int[length + 1]; 
		int runningProd = 1; 
		
		pArray[0] = 1; 
		pArray[length] = 1; 
		for (int i = 1; i <= length; i++)
		{
			runningProd = runningProd * array[i-1]; 
			pArray[i] = runningProd; 
		}
		//reset running poduct and do reverse
		runningProd = 1;
		for (int i = length -1; i >= 0; i--)
		{
			runningProd = runningProd * array[i+1]; 
			pArray[i] =  pArray[i] * runningProd; 
		}
		
		return pArray;
	}
}
