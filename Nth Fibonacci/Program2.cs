using System;

public class Program2 {
	public static int GetNthFib(int n) {
		// Write your code here.
        int[] lastTwo = {0,1}; 
        if (n == 1)
            return 0;
        int i = 2; 
        int o = 1; 
        while (i < n)
        {
            o = lastTwo[0] + lastTwo[1];
            lastTwo = new int[]{lastTwo[1], o};
            i++;
        }
		return o;
	}
}
