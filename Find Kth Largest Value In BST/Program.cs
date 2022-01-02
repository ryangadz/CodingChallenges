using System;
using System.Collections.Generic; 


public class Program {
	// This is an input class. Do not edit.
	public class BST {
		public int value;
		public BST left = null;
		public BST right = null;

		public BST(int value) {
			this.value = value;
		}
	}


	public int FindKthLargestValueInBst(BST tree, int k) {
		// Write your code here.
		int count = 0 ;
		int lastVisited = -1; 
		kNode(tree, k, ref count, ref lastVisited); 
		return lastVisited;
	}
	
	public static void kNode(BST tree, int k, ref int count, ref int lastVisited)
	{
		if (tree == null || count >= k)
			return; 
		kNode(tree.right, k, ref count, ref lastVisited); 
		if (count < k)
		{
			count++; 
			lastVisited = tree.value; 
			kNode(tree.left, k, ref count, ref lastVisited); 
		}			
	}
}
