using System;
using System.Collections.Generic;

public class Program {
	public static BST MinHeightBst(List<int> array) {
		// Write your code here.
		int length = array.Count - 1; 
		int leftA = 0;
		int rightA = length; 
		
		//BST minHeightBST = new BST(array[length/2]); 
		
		return addBST(array, leftA, rightA);
	}
	
	public static BST addBST (List<int> array, int l, int r)
	{
		if (l > r) 
			return null; 
		//else make new
		int mid = (l + r)/2; 
		BST newBST = new BST(array[mid]); 
		newBST.left = addBST(array, l, mid - 1); 
		newBST.right = addBST(array, mid + 1, r ); 
		return newBST; 
	}

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
			left = null;
			right = null;
		}

		public void insert(int value) {
			if (value < this.value) {
				if (left == null) {
					left = new BST(value);
				} else {
					left.insert(value);
				}
			} else {
				if (right == null) {
					right = new BST(value);
				} else {
					right.insert(value);
				}
			}
		}
	}
}
