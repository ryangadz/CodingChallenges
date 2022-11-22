using System;

public class Program2 {
	public int[] SortedSquaredArray(int[] array) {
		// Write your code here.
        int length = array.Length; 
        int[] oArray = new int[length];
        int l = 0; 
        int r = length - 1; 
        for (int i = 0; i < length; i++)
        {
            int left = Math.Abs(array[l]); 
            int right = Math.Abs(array[r]); 
            int index = length-i-1; 
            if (left > right)
            {
                oArray[index] = (int)Math.Pow(array[l], 2);
                l++;      
            }
            else
            {
                oArray[index] = (int)Math.Pow(array[r], 2); 
                r--; 
            }
        }
		return oArray;
	}
}
