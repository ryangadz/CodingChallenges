using System;
using System.Collections.Generic;

public class Program {
	// This is the class of the input root. Do not edit it.
	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) {
		// Write your code here.
		List<int> sums = new List<int>(); 
		BranchSumsRec(root, 0, sums );
		return sums; 
	}
	
	public static void BranchSumsRec(BinaryTree root, int sum, List<int> sums)
	{
		if (root == null)
			return ; 
		int addedSum = sum + root.value; 
		if (root.left == null && root.right == null)
		{
			sums.Add(addedSum); 
			return; 
		}
		BranchSumsRec(root.left, addedSum, sums); 
		BranchSumsRec(root.right, addedSum, sums); 
	}
	
}
