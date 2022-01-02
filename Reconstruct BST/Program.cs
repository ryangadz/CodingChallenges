using System.Collections.Generic;
using System;


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


	public BST ReconstructBst(List<int> preOrderTraversalValues) {
		// Write your code here.
		//int rootIndex = 0; 
 		TreeInfo treeInfo = new TreeInfo(0); 
		return AddNode(preOrderTraversalValues, Int32.MinValue, Int32.MaxValue, treeInfo);
	}
	
	public static BST AddNode(List<int> pOTV, int lBounds, int uBounds, TreeInfo currTreeInfo)
	{
		if (currTreeInfo.rootIndex == pOTV.Count)
			return null;
		int rootValue = pOTV[currTreeInfo.rootIndex]; 
		if (rootValue < lBounds || rootValue >= uBounds)
			return null; 
		currTreeInfo.rootIndex += 1; //move to next
		BST newNode = new BST(rootValue); 
		newNode.left = AddNode(pOTV, lBounds, rootValue, currTreeInfo); 
		newNode.right = AddNode(pOTV, rootValue, uBounds, currTreeInfo); 
		return newNode; 
	}
	
	public class TreeInfo
	{
		public int rootIndex = 0; 
		public TreeInfo(int rootIndex)
		{
			this.rootIndex = rootIndex; 
		}
	}
}
