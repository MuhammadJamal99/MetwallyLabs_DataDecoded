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
//StackArrayBased<int> myArrayStack = new(false);
//myArrayStack.Push(0);
//myArrayStack.Push(0);
//myArrayStack.Push(1);
//myArrayStack.Push(2);
//myArrayStack.Push(3);
//myArrayStack.Push(4);
//myArrayStack.Push(5);
//myArrayStack.Push(5);
//myArrayStack.Print();

//myArrayStack.Pop();
//myArrayStack.Print();


//myArrayStack.Pop();
//myArrayStack.Print();
#endregion

#region QueueLinkedListBased
//using DataDeCoded.DictionaryArrayBased;
//using DataDeCoded.DictionaryLinkedListBased;
//using DataDeCoded.HashTable;
//using DataDeCoded.HashTableFunctions;
//using DataDeCoded.QueueArrayBased;

//QueueLinkedListBased<int> myLinkedListQueue = new(false);

//myLinkedListQueue.EnQueue(0);
//myLinkedListQueue.EnQueue(1);
//myLinkedListQueue.EnQueue(2);
//myLinkedListQueue.EnQueue(3);

//myLinkedListQueue.Print();

#endregion

#region QueueArrayBased

//QueueArrayBased<int> myArrayQueue = new(false);

//myArrayQueue.EnQueue(0);
//myArrayQueue.EnQueue(1);
//myArrayQueue.EnQueue(2);
//myArrayQueue.EnQueue(3);
//myArrayQueue.EnQueue(4);
//myArrayQueue.EnQueue(5);
//myArrayQueue.EnQueue(6);
//myArrayQueue.EnQueue(7);
//myArrayQueue.EnQueue(8);
//myArrayQueue.EnQueue(9);
//myArrayQueue.EnQueue(10);
//myArrayQueue.EnQueue(11);
//myArrayQueue.Print();

//myArrayQueue.DeQueue();
//myArrayQueue.Print();

//myArrayQueue.DeQueue();
//myArrayQueue.Print();

//myArrayQueue.DeQueue();
//myArrayQueue.Print();

//myArrayQueue.DeQueue();
//myArrayQueue.Print();

//Console.WriteLine(myArrayQueue.Top());

//myArrayQueue.Print();

#endregion

#region DictionaryArrayBased
//DictionaryArrayBased<string, int> myDic = new DictionaryArrayBased<string, int>();
//myDic.Set("zero", 0);
//myDic.Set("one", 1);
//Console.WriteLine(myDic.Get("one"));
//Console.WriteLine(myDic.Remove("zero"));
//myDic.Set("two", 2);
//myDic.Set("three", 3);
//Console.WriteLine(myDic.Remove("three"));
//myDic.Set("four", 4);
//Console.WriteLine(myDic.Get("three"));
//myDic.Set("five", 5);
//Console.WriteLine(myDic.Get("four"));
//myDic.Set("six", 6);
//Console.WriteLine(myDic.Remove("five"));
//Console.WriteLine(myDic.Remove("six"));
//Console.WriteLine(myDic.Remove("two"));
//Console.WriteLine(myDic.Remove("one"));
//Console.WriteLine(myDic.Remove("four"));
//myDic.Print();
//myDic.Set("zero", 0);
//myDic.Set("one", 1);
//myDic.Print();
#endregion

#region DictionaryLinkedListBased
//DictionaryLinkedListBased<string, int> myDic = new DictionaryLinkedListBased<string, int>();
//myDic.Set("zero", 0);
//myDic.Set("one", 1);
//Console.WriteLine(myDic.Get("one"));
//Console.WriteLine(myDic.Remove("zero"));
//myDic.Print();

//myDic.Set("two", 2);
//myDic.Set("three", 3);
//Console.WriteLine(myDic.Remove("three"));
//myDic.Print();
//myDic.Set("four", 4);
//Console.WriteLine(myDic.Get("three"));
//myDic.Set("five", 5);
//Console.WriteLine(myDic.Get("four"));
//myDic.Set("six", 6);
//Console.WriteLine(myDic.Remove("five"));
//Console.WriteLine(myDic.Remove("six"));
//Console.WriteLine(myDic.Remove("two"));
//Console.WriteLine(myDic.Remove("one"));
//Console.WriteLine(myDic.Remove("four"));
//myDic.Print();
//myDic.Set("zero", 0);
//myDic.Set("one", 1);
//myDic.Print();
#endregion

#region  Hash
//HashFNV1a hash = new HashFNV1a();
//hash.HashFNV1a32("This is Original Text");
//hash.HashFNV1a64("This is Original Text");
//hash.HashFNV1a128("This is Original Text");
//hash.HashFNV1a256("This is Original Text");
//hash.HashFNV1a512("This is Original Text");
////hash.HashFNV1a32("This is Original Text");
////hash.HashFNV1a32("This is Original Text");
#endregion

#region HashTable
//HashTable<string, string> myHashTable = new HashTable<string, string>();
//myHashTable.Print();
//myHashTable.Set("Sinar", "sinar@gmail.com");
//myHashTable.Set("Elvis", "elvis@gmail.com");
//myHashTable.Set("Tane", "tane@gmail.com");
//myHashTable.Print();

//myHashTable.Set("Gerti", "gerti@gmail.com");
//myHashTable.Set("Arist", "arist@gmail.com");
//myHashTable.Print();
//Console.WriteLine("[Get] {0}", myHashTable.Get("Sinar"));
//Console.WriteLine("[Get] {0}", myHashTable.Get("Tane"));
//Console.WriteLine("[Get] {0}", myHashTable.Get("Sinar"));
//Console.WriteLine("[Get] {0}", myHashTable.Get("Sinar"));
#endregion

#region BinaryTree
using DataDeCoded.BinaryTree;
//8, 3, 10, 1, 6, 4, 7, 14, 13
BinaryTree<int> binaryTree = new();
binaryTree.Insert(8);
binaryTree.Insert(3);
binaryTree.Insert(10);
binaryTree.Insert(1);
binaryTree.Insert(6);
binaryTree.Insert(4);
binaryTree.Insert(7);
binaryTree.Insert(14);
binaryTree.Insert(13);

binaryTree.Print();
#endregion