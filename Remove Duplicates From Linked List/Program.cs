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

	public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
		// Write your code here.
		LinkedList currentList = linkedList; 
		while (currentList != null)
		{
			LinkedList nextList = currentList.next; 
			while (nextList != null && currentList.value == nextList.value)
			{
				nextList = nextList.next; 
			}
			currentList.next = nextList; 
			currentList = nextList; 
		}
		return linkedList;
	}
}

