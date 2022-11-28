using System.Collections.Generic;
using System;

public class Program {
	// This is an input class. Do not edit.
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

    public struct SC
    {
        public int sum; 
        public int carry; 
    }

	public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo) {
		// Write your code here.
        LinkedList currentNodeOne = linkedListOne;
        LinkedList currentNodeTwo = linkedListTwo;
        
        SC sc = new SC(); 

        LinkedList returnList = new LinkedList(0);  
        LinkedList currentNode = returnList; 

        while (currentNodeOne != null || currentNodeTwo != null || sc.carry > 0)
        {
            sc = SumPlusCarry(currentNodeOne, currentNodeTwo, sc.carry); 
            LinkedList newNode = new LinkedList(sc.sum); 
            currentNode.next = newNode; 
            currentNode = currentNode.next; 
            
            currentNodeOne = (currentNodeOne != null) ? currentNodeOne.next : null; 
            currentNodeTwo = (currentNodeTwo != null) ? currentNodeTwo.next : null; 
        }
		return returnList.next;
	}

    public SC SumPlusCarry(LinkedList ll1, LinkedList ll2, int c)
    {
        SC sc = new SC();
        int v1 = (ll1 != null) ? ll1.value : 0; 
        int v2 = (ll2 != null) ? ll2.value : 0; 
        int sum = (v1 + v2 + c);
        sc.sum = sum % 10; 
        sc.carry = sum / 10; 
       
        return sc; 
    }
}

