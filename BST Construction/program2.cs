using System;
//iterative solution O(1) space
public class Program2 {
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
            BST cNode = this; 
            while(true)
            {
                if (value < cNode.value)
                {
                    if (cNode.left == null)
                    {
                        cNode.left = new BST(value); 
                        break; 
                    }
                    else
                        cNode = cNode.left; 
                }
                else
                {
                    if (cNode.right == null)
                    {
                        cNode.right = new BST(value); 
                        break; 
                    }
                    else 
                        cNode = cNode.right; 
                }   
            }

			return this;
		}

		public bool Contains(int value) {
			// Write your code here.
            BST cNode = this; 
            while(cNode != null)
            {
                if (value < cNode.value)   
                    cNode = cNode.left; 
                else if (value > cNode.value)
                    cNode = cNode.right; 
                else
                    return true; 
            }
			return false;
		}

		public BST Remove(int value, BST pNode = null) {
			// Write your code here.
			// Do not edit the return statement of this method.
            BST cNode = this; 
            while (cNode != null)
            {
                if (value < cNode.value)
                {
                    pNode = cNode; 
                    cNode = cNode.left; 
                }
                else if(value > cNode.value)
                {
                    pNode = cNode; 
                    cNode = cNode.right; 
                }
                else
                {
                    //node with 2 children
                    if (cNode.left != null && cNode.right != null)
                    {
                        cNode.value = cNode.right.GetMin(); 
                        cNode.right.Remove(cNode.value, cNode);
                    }
                    //root node case
                    else if (pNode == null)
                    {
                        if (cNode.left != null)
                        {
                            cNode.value = cNode.left.value; 
                            cNode.right = cNode.left.right; 
                            cNode.left = cNode.left.left; 
                        }
                        else if (cNode.right != null)
                        {
                            cNode.value = cNode.right.value; 
                            cNode.left = cNode.right.left; 
                            cNode.right = cNode.right.right; 
                        }
                        else //root without children do nothing
                        {
                            
                        }
                    }
                    //node with one child or none
                    else if (pNode.left == cNode)
                    {
                        if (cNode.left != null)
                            pNode.left = cNode.left; 
                        else
                            pNode.left = cNode.right; 
                    }
                    else if (pNode.right == cNode)
                    {
                        if (cNode.left != null)
                            pNode.right = cNode.left; 
                        else
                            pNode.right = cNode.right; 
                    }
                    break; 
                }
            }
            
			return this;
		}

        public int GetMin()
        {
            if (left == null)
                return this.value; 
            else
                return left.GetMin(); 
        }
	}
}
