using System;

public class Program {
	public static int NodeDepths(BinaryTree root) {
		// Write your code here.
		int sum = 0; 
		AddNodeDepths(root, ref sum, 0); 
		return sum;
	}
	
	public static void AddNodeDepths(BinaryTree node, ref int sum, int depth) 
	{
		sum += depth; 
		if (node.left != null)
			AddNodeDepths(node.left, ref sum, depth + 1); 
		if (node.right != null)
			AddNodeDepths(node.right, ref   sum, depth + 1); 
	}
	

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
}
