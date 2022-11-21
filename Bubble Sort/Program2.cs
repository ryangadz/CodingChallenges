using System;

public class Program2 {
	public static int[] BubbleSort(int[] array) {
		// Write your code here.
        bool swapped = true; 
        int length = array.Length - 1; 
        while (swapped == true)
        {
            swapped = false;
            for (int i = 0; i < length; i++)
            {
                if (array[i] > array[i+1])
                {
                    swap(array, i); 
                    swapped = true;           
                }
            }
            length -= 1; 
        }
		return array;
	}
    static void swap(int[] a, int i)
    {
        int temp = a[i]; 
        a[i] = a[i+1];
        a[i+1] = temp;
    }
}
