#region SinglyLinkedList
//DataDeCoded.SinglyLinkedList.LinkedList<int> myList = new();
//myList.InsertLast(1);
//myList.Print();
//myList.DeleteNode(1);
//myList.Print();


//myList.InsertLast(2);
//myList.InsertLast(3);
//myList.DeleteNode(1);
//myList.Print();

//myList.InsertLast(4);

//myList.DeleteNode(4);
//myList.Print();


//myList.InsertAfter(3, 98);
//myList.Print();
//myList.InsertBefore(98, 5);
//myList.Print();
//myList.DeleteNode(5);
//myList.Print();
//myList.InsertBefore(1, 0);
//myList.Print();
#endregion

#region DoublyLinkedList

//DataDeCoded.DoublyLinkedList.DoublyLinkedList<int> myList = new(false);
//myList.InsertLast(1);
//myList.Print();

//myList.InsertLast(2);
//myList.InsertLast(2);
//myList.InsertLast(3);
//myList.Print();

//myList.InsertLast(4);
//myList.Print();


//myList.InsertAfter(3, 98);
//myList.Print();
//myList.InsertBefore(98, 5);
//myList.Print();
//myList.InsertBefore(2, 0);
//myList.Print();

//DataDeCoded.DoublyLinkedList.DoublyLinkedList<int> copiedList = new(false);

//myList.CopyTo(copiedList);

//copiedList.Print();


#endregion

#region StackLinkedListBased
using DataDeCoded.StackArrayBased;

//StackLinkedListBased<int> myLinkedListStack = new(false);
//myLinkedListStack.Push(0);
//myLinkedListStack.Push(1);
//myLinkedListStack.Push(2);
//myLinkedListStack.Push(3);
//myLinkedListStack.Push(4);
//myLinkedListStack.Push(5);
//myLinkedListStack.Print();

//myLinkedListStack.Pop();
//myLinkedListStack.Print();


//myLinkedListStack.Pop();
//myLinkedListStack.Print();
#endregion

#region StackArrayBased

StackArrayBased<int> myArrayStack = new(false);
myArrayStack.Push(0);
myArrayStack.Push(0);
myArrayStack.Push(1);
myArrayStack.Push(2);
myArrayStack.Push(3);
myArrayStack.Push(4);
myArrayStack.Push(5);
myArrayStack.Push(5);
myArrayStack.Print();

myArrayStack.Pop();
myArrayStack.Print();


myArrayStack.Pop();
myArrayStack.Print();
#endregion