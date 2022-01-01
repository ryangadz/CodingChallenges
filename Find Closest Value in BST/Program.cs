using System;

public class Program {
	public static int FindClosestValueInBst(BST tree, int target) {
		// Write your code here.
		
		return FindClosestValueInBst(tree, target, tree.value); ;
	}
	public static int FindClosestValueInBst(BST tree, int target, int closest)
	{
		
		if (target == closest)
			return closest; 
		if (Math.Abs(target- closest) > Math.Abs(target - tree.value))
			closest = tree.value; 
		if (target < tree.value && tree.left != null)
			return FindClosestValueInBst(tree.left, target, closest); 
		else if (target > tree.value && tree.right != null)
			return FindClosestValueInBst(tree.right, target, closest); 
		else return closest; 
		
	}

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}
}
