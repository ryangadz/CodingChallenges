using System;

public class Program {
	public static void InvertBinaryTree(BinaryTree tree) {
		// Write your code here.
		SwapNodes(tree); 
	}
	
	public static void SwapNodes(BinaryTree node)
	{
		if (node == null)
			return; 
		BinaryTree temp = node.left; 
		node.left = node.right; 
		node.right = temp; 
		SwapNodes(node.left); 
		SwapNodes(node.right); 
			
		
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
}
