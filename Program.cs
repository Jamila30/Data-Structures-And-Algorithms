
#region Searching Algorithms

#region Linear Search

using DataStructuresAndAlgorithms.SearchingAlgorithms.BinarySearch;
using DataStructuresAndAlgorithms.SearchingAlgorithms.LinearSearch;
using DataStructuresAndAlgorithms.SortingAlgorithms;

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

int[] unSortedArray = [3, 2, 1, 5, 4, 1];
InsertionSort selectionSort = new InsertionSort();
int[] sortedArray = selectionSort.SortArray_Insertion(unSortedArray);
Console.WriteLine($"[{string.Join(",", sortedArray)}]");

#endregion


#endregion