using System;
// O(n * m) time and O(n * m) space
public class Program {
	public int NumberOfWaysToTraverseGraph(int width, int height) {
		// Write your code here.
        int[,] graph = new int[width, height]; 
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++ )
            {
                if (w == 0)
                    graph[0,h] = 1; 
                else if(h == 0)
                    graph[w,0] = 1;              
                else 
                    graph[w,h] =(graph[w-1,h] + graph[w,h-1]); 
            }
        }
		return graph[width-1, height-1];
	}
}
