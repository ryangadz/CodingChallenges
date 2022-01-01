using System;

public class Program {
	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}

		public BST Insert(int value) {
			// Write your code here.
			// Do not edit the return statement of this method.
			if (value < this.value) // handle  left
			{
				if (left == null)
				{
					BST bst = new BST(value); 
					left = bst; 
				}
				else	
					left.Insert(value);				
			}
			else                   // handle right
			{
				if (right == null)
				{
					BST bst = new BST(value); 
					right = bst; 
				}
				else	
					right.Insert(value);		
			}
			return this;
		}

		public bool Contains(int value) {
			// Write your code here.
			if (value == this.value)
				return true; 
			else if (value < this.value)
			{
				if (left != null)
					return left.Contains(value);
				else return false; 
			}
			else
			{
				if (right != null)
					return right.Contains(value); 
				else return false; 
			}
		}
		
		public BST Remove(int value) {
			// Write your code here.
			// Do not edit the return statement of this method.
			Remove(value, null); 
			return this;
		}

		public void Remove(int value, BST parent) 
		{
			if (value == this.value) // node to remove
			{
				if (left != null && right != null) //full tree
				{
					this.value = right.GetMin();
					right.Remove(this.value, this); 
				}
				else if (parent == null)
				{
					if (left != null)
					{
						this.value = left.value; 
						right = left.right; 
						left = left.left; 
					}
					else if (right != null)
					{
						this.value = right.value; 
						left = right.left; 
						right = right.right; 		
					}
					else{}

				}
				else if (parent.left == this) //set new left node
				{
					if (left == null)
						parent.left = right;
					else parent.left = left; 
				}	
				else if (parent.right == this) //set new right node
				{
					if (left == null)
						parent.right = right;
					else parent.right = left; 
				}


						
			}
			else if (value < this.value) //keep on searching left
			{
				if (left != null)
					left.Remove(value, this);
			}
			else
			{
				if (right != null)
					right.Remove(value, this); //keep on searching right
			}
				
		}
		
		public int GetMin()
		{
			if (left == null)
				return this.value; 
			else return left.GetMin(); 
		}
	}
}
