using System;
using System.Collections.Generic;

public class Program2 {
	public static List<int> MoveElementToEnd(List<int> array, int toMove) {
		// Write your code here.
        int left = 0; 
        int right = array.Count - 1; 
        while (left < right)
        {
            while (left < right && array[right] == toMove)
                right--; 
            if (array[left] == toMove)
            {
                int temp = array[right];
                array[right] = array[left];
                array[left] = temp; 
            }
            left++; 
        }
		return array;
	}
}