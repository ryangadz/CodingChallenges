using System;
using System.Collections.Generic;

public class Program 
{
	public static int[] TwoNumberSum(int[] array, int targetSum) 
    {
		// Write your code here.
        int right = array.Length - 1; 
        int left = 0; 
        Array.Sort(array); 
        while (left < right)
        {
            int sum =  array[left] + array[right]; 
            if (sum == targetSum)
            {
                int[] pair = new int[2]; 
                pair[0] = array[left]; 
                pair[1] = array[right]; 
                return pair; 
            }
            if (sum < targetSum)
            {
                left++; 
            }
            else right--; 
        }
		return new int[0];
	}
}
