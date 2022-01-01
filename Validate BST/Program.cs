using System;

public class Program {
	public static bool ValidateBst(BST tree) {
		// Write your code here.
		return Validate(tree, Int32.MinValue, Int32.MaxValue );
	}
	public static bool Validate(BST tree, int min, int max)
	{
		if (tree.value < min || tree.value >= max) //less than min or greater than max
			return false; 
		if (tree.left != null && !Validate(tree.left, min, tree.value)) // left exists but tree is not valid
			return false; 
		if (tree.right != null && !Validate(tree.right, tree.value, max)) //right exists but tree is not valid
			return false; 
		return true; 
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
