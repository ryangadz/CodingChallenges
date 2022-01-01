using System.Collections.Generic;
using System;


public class Program {

	public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights) {
		// Write your code here.
		redShirtHeights.Sort(); 
		blueShirtHeights.Sort(); 
		int tallestIndex = redShirtHeights.Count - 1; 
		bool isBackRed = false; 
		bool itsHappening = true; 
		if (redShirtHeights[tallestIndex] > blueShirtHeights[tallestIndex])
			isBackRed = true; 
		if (tallestIndex == 0 && redShirtHeights[0] == blueShirtHeights[0])
			return false; 
		for (int i = 0; i < tallestIndex; i++)
		{
			if (isBackRed)
			{
				if (redShirtHeights[i] <= blueShirtHeights[i]) 
					return false; 
			}
			else
			{
				if (redShirtHeights[i] >= blueShirtHeights[i]) 
					return false; 
			}
		}
		
		return itsHappening;
	}
}
