using System;

public class Program {
	public static bool HasSingleCycle(int[] array) {
		// Write your code here.
        int length = array.Length; 
        int curIndex = 0; 
        for (int i = 0; i < length; i++)
        {
            if (i > 0 && curIndex == 0)
                return false;
            curIndex = JumpIndex(length, curIndex, array[curIndex]); 
        }
		return curIndex == 0;
	}
    public static int JumpIndex(int len, int curIndex, int v)
    {
        int r = (curIndex+v)%len; 
        if (r < 0)
            r = len + r; 
        return r; 
    }
}
