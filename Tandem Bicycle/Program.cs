using System;

public class Program {

	public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) {
		// Write your code here.
		Array.Sort(redShirtSpeeds); 
		Array.Sort(blueShirtSpeeds); 
	//	Array.Reverse(blueShirtSpeeds); 
		int totalSpeed = 0; 
		int length = redShirtSpeeds.Length; 
		for (int i = 0; i < length; i++)
		{
			if (fastest)
				totalSpeed += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[length-1-i]); 
			else 				
				totalSpeed += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]); 
		}
		return totalSpeed;
	}
}
