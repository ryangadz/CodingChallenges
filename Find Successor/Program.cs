using System;


public class Program {
	// This is an input class. Do not edit.
	public class BinaryTree {
		public int value;
		public BinaryTree left = null;
		public BinaryTree right = null;
		public BinaryTree parent = null;

		public BinaryTree(int value) {
			this.value = value;
		}
	}

//O(h) time | O(h) space
	public BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node) {
		// Write your code here.
		if (node.right != null)
			return GetLeftmostChild(node); 
		return GetRightmostParent(node); 
	}
	
	public BinaryTree GetLeftmostChild(BinaryTree node)
	{
		BinaryTree currNode = node.right; 
		while (currNode.left != null)
		{
			currNode = currNode.left; 
		}
		return currNode; 
	}
	
	public BinaryTree GetRightmostParent(BinaryTree node)
	{
		BinaryTree currNode = node; 
		while (currNode.parent != null && currNode.parent.right == currNode)
		{
			currNode = currNode.parent; 
		}
		return currNode.parent; 
	}
}
