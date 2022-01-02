using System;


public class Program {
	public int BinaryTreeDiameter(BinaryTree tree) {
		// Write your code here.
		int diameter = getTreeInfo(tree).diameter; 
		return diameter;
	}

	public TreeInfo getTreeInfo(BinaryTree tree)
	{
		if(tree == null)
			return new TreeInfo(0,0); 
		TreeInfo leftTree = getTreeInfo(tree.left); 
		TreeInfo rightTree = getTreeInfo(tree.right); 
		
		int longestThroughRoot = leftTree.height + rightTree.height; 
		int maxDia = Math.Max(leftTree.diameter, rightTree.diameter); 
		int currDia = Math.Max(longestThroughRoot, maxDia); 
		int currHeight = 1 + Math.Max(leftTree.height, rightTree.height); 
		TreeInfo newTreeInfo = new TreeInfo(currDia, currHeight); 
		return newTreeInfo; 
	}
	
	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
	
	public class TreeInfo
	{
		public int diameter; 
		public int height; 
		public TreeInfo(int diameter, int height) 
		{
			this.diameter = diameter; 
			this.height = height; 
		}
	}
}

