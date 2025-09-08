﻿
#region Searching Algorithms

#region Linear Search

//int[] searchArray = [2, 1, 3, 4, 9, 6];

//LinearSearchOperation linerSearchOperation = new LinearSearchOperation();
//Console.WriteLine("___________Linear Search ___________");
//Console.ReadLine();
//Console.WriteLine("___________Iterative ___________");
//linerSearchOperation.FindValue_Iterative(9, searchArray,6);
//Console.WriteLine("___________Recursive___________");
//linerSearchOperation.FindValue_Recursive(9, searchArray,6);

#endregion

#region Binary Search

//int[] sortedArray = [2, 4, 5, 11];

//Console.WriteLine($"Binary Search on array ");

//BinarySearchOperation binarySearchOperation = new BinarySearchOperation();
//int foundedIndex1 =binarySearchOperation.FindValue_Iterative(11,sortedArray,0,sortedArray.Length);
//Console.WriteLine($"Founded index (iterative way) : {foundedIndex1}");

//int foundedIndex2 =binarySearchOperation.FindValue_Recursive(11,sortedArray,0,sortedArray.Length);
//Console.WriteLine($"Founded index (recursive way) : {foundedIndex2}");

#endregion


#endregion

#region Sorting Algorithms

#region Selection Sort

//int[] unSortedArray = [3,2,1,5,4,1];
//SelectionSort selectionSort = new SelectionSort();
//int[] sortedArray=selectionSort.SortArray_Selection(unSortedArray);
//Console.WriteLine($"[{string.Join(",",sortedArray)}]");

#endregion

#region Insertion sort

//int[] unSortedArray = [3, 2, 1, 5, 4, 1];
//InsertionSort insertionSort = new InsertionSort();
//int[] sortedArray = insertionSort.SortArray_Insertion(unSortedArray);
//Console.WriteLine($"[{string.Join(",", sortedArray)}]");

#endregion

#region Bubble sort

//int[] unSortedArray = [3, 2, 1, 5, 4, 1,9,0];
//BubbleSort bubbleSort = new BubbleSort();
//int[] sortedArray = bubbleSort.SortArray_Bubble(unSortedArray);
//Console.WriteLine($"[{string.Join(",", sortedArray)}]");

#endregion

#region Shell sort

//int[] unSortedArray = { 100, 99, 98, 1, 2, 3, 4, 5, 6 };

//ShellSort shellSort = new ShellSort();
//int[] sortedArray = shellSort.SortArray_Shell(unSortedArray);
//Console.WriteLine($"[{string.Join(",", sortedArray)}]");

#endregion

#region Merge sort

//int[] unsortedArray = { 100, 99, 98, 1, 2, 3, 4, 5, 6 };

//MergeSort mergeSort = new MergeSort();
//int[] sortedArray = mergeSort.SortArray_Merge(unsortedArray, 0, 8);
//Console.WriteLine($"[{string.Join(",", sortedArray)}]");


#endregion

#region Quick sort

//int[] unsortedArray = { 3,100, 99, 2,98, 4, 101, 1 };

//QuickSort quickSort = new QuickSort();
//int[] sortedArray = quickSort.SortArray_Quick(unsortedArray, 0, 7);
//Console.WriteLine($"[{string.Join(",", sortedArray)}]");



#endregion

#endregion


#region Data Structures

#region Linked List

#region Linear Linked List

//LinkedList<string> list = new LinkedList<string>();
//list.AddLast("test");
//list.AddLast("test1");
//list.AddLast("test2");

//Console.WriteLine(string.Join(" ", list.Select(r => r)));

//LinearLinkedList<string> nodeList = new LinearLinkedList<string>();

//nodeList.AddLast("Test");
//nodeList.AddLast("Test1");
//nodeList.AddLast("Test2");
//nodeList.AddLast("Test3");

//nodeList.AddFirst("Test");
//nodeList.AddFirst("Test1");
//nodeList.AddFirst("Test2");
//nodeList.AddFirst("Test3");

//nodeList.RemoveAny(1);
//Console.WriteLine(string.Join(" ", nodeList.Select(r => r)));

//Console.WriteLine(nodeList.Search("Test1"));
//Console.WriteLine(nodeList.Search("Test111"));

#endregion

#region Circular Linked List

//CircularLinkedList<string> nodeList = new CircularLinkedList<string>();
//nodeList.AddLast("Test");
//nodeList.AddLast("Test1");
//nodeList.AddLast("Test2");
//nodeList.AddLast("Test3");

//nodeList.AddFirst("Test");
//nodeList.AddFirst("Test1");
//nodeList.AddFirst("Test2");
//nodeList.AddFirst("Test3");

//nodeList.AddToAny(1, "Added test for position 1");

//nodeList.DeleteFirst();
//nodeList.DeleteLast();
//nodeList.DeleteAtPosition(0);

//Console.WriteLine(string.Join(" ", nodeList.Select(r => r)));


#endregion

#region DoublyLinkedList

//DoublyLinkedList<string> nodeList = new DoublyLinkedList<string>();

//nodeList.AddLast("Test");
//nodeList.AddLast("Test1");
//nodeList.AddLast("Test2");
//nodeList.AddLast("Test3");

//nodeList.AddFirst("Test");
//nodeList.AddFirst("Test1");
//nodeList.AddFirst("Test2");
//nodeList.AddFirst("Test3");

//nodeList.AddToPosition(3, "Pos3");

//nodeList.DeleteFirst();
//nodeList.DeleteLast();
//nodeList.DeleteAtPosition(1);


//Console.WriteLine(string.Join(" ", nodeList.Select(r => r)));


#endregion


#endregion

#region Stack

#endregion

#endregion