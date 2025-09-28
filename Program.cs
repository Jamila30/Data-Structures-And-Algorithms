using DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Linear;
using DataStructuresAndAlgorithms.DataStructures.NonLinear.BinarySearchTrees;
using DataStructuresAndAlgorithms.DataStructures.NonLinear.Graphs;
using DataStructuresAndAlgorithms.DataStructures.NonLinear.Hashes;
using DataStructuresAndAlgorithms.DataStructures.NonLinear.Heaps;

Console.WriteLine("Start");

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

#region Linear

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

//Console.WriteLine(nodeList.Search("Test"));
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


#region Array Base Stack  

//using DataStructuresAndAlgorithms.DataStructures.Stacks;
//using DataStructuresAndAlgorithms.DataStructures.Stacks.LinkedListBaseStack;

//ArrayBaseStack<string> myStack = new ArrayBaseStack<string>(4);
//myStack.Push("Test");
//myStack.Push("Test1");
//myStack.Push("Test2");
//myStack.Push("Test3");
//myStack.Push("Test4");


//string peekValue =myStack.Peek();
//Console.WriteLine($"Peek value : {peekValue}");

//myStack.Pop();

//Console.WriteLine(string.Join(" ", myStack.Select(s => s)));

#endregion

#region LinkedList Base Stack

//StackLinkedList<string> myLinkedStack = new StackLinkedList<string>();
//myLinkedStack.Push("Test");
//myLinkedStack.Push("Test1");
//myLinkedStack.Push("Test2");
//myLinkedStack.Push("Test3");

//myLinkedStack.Pop();

//string peekValue = myLinkedStack.Peek();

//Console.WriteLine(string.Join(" ", myLinkedStack.Select(s => s)));

#endregion


#endregion

#region Queue

#region Array Base Queue

//ArrayBaseQueue<string> queue = new ArrayBaseQueue<string>();
//queue.Enqueue("a");
//queue.Enqueue("b");
//queue.Enqueue("c");
//queue.Enqueue("d");
//queue.Enqueue("e");

//queue.Dequeue();

//queue.Enqueue("f");
//queue.Enqueue("g");
//queue.Enqueue("h");
//queue.Enqueue("i");
//queue.Enqueue("x");


#endregion

#region Linked List base Queue


//QueueLinkedList<string> queueLinkedList = new QueueLinkedList<string>();
//queueLinkedList.Enqueue("a");
//queueLinkedList.Enqueue("b");
//queueLinkedList.Enqueue("c");
//queueLinkedList.Enqueue("d");
//queueLinkedList.Enqueue("e");

//queueLinkedList.Dequeue();

//string firstElement = queueLinkedList.First();
//Console.WriteLine(firstElement);



//Console.WriteLine(string.Join(" | ", queueLinkedList.Select(r => r)));

#endregion


#endregion

#region Deque

//DequeLinkedList<string> dequeLinkedList = new DequeLinkedList<string>();
//dequeLinkedList.AddLast("a");
//dequeLinkedList.AddLast("b");
//dequeLinkedList.AddLast("c");
//dequeLinkedList.AddFirst("d");
//dequeLinkedList.AddFirst("e");
//dequeLinkedList.AddFirst("f");

//string firstElement = dequeLinkedList.First();
//string lastElement = dequeLinkedList.Last();
//Console.WriteLine(firstElement);
//Console.WriteLine(lastElement);

//Console.WriteLine(string.Join(" | ", dequeLinkedList.Select(r => r)));

//dequeLinkedList.RemoveFirst();
//dequeLinkedList.RemoveLast();

//Console.WriteLine(string.Join(" | ", dequeLinkedList.Select(r => r)));



#endregion
#endregion

#region Non-Linear

#region Binary Search Tree
//BinarySearchTreeLinkedList<int> binarySearchTreeLinkedList = new BinarySearchTreeLinkedList<int>();
//binarySearchTreeLinkedList.IterativeInsert(50);
//binarySearchTreeLinkedList.IterativeInsert(30);
//binarySearchTreeLinkedList.IterativeInsert(20);
//binarySearchTreeLinkedList.IterativeInsert(10);
//binarySearchTreeLinkedList.IterativeInsert(40);
//binarySearchTreeLinkedList.IterativeInsert(60);
//binarySearchTreeLinkedList.IterativeInsert(90);

//binarySearchTreeLinkedList.PreOrderBinarySearchTree(binarySearchTreeLinkedList._root);
//binarySearchTreeLinkedList.PostOrderBinarySearchTree(binarySearchTreeLinkedList._root);
//binarySearchTreeLinkedList.InOrderBinarySearchTree(binarySearchTreeLinkedList._root);
//binarySearchTreeLinkedList.LevelOrderBinarySearchTree();
//Console.WriteLine(binarySearchTreeLinkedList.Search(110)); 
//binarySearchTreeLinkedList.DeleteLeafNode(30);
//binarySearchTreeLinkedList.DeleteNodeWithOneSubTree(20);



//binarySearchTreeLinkedList.RecursiveInsert2(50,binarySearchTreeLinkedList._root);
//binarySearchTreeLinkedList.RecursiveInsert2(30, binarySearchTreeLinkedList._root);

//binarySearchTreeLinkedList.RecursiveInsert(50);
//binarySearchTreeLinkedList.RecursiveInsert(30);
//binarySearchTreeLinkedList.RecursiveInsert(80);
//binarySearchTreeLinkedList.RecursiveInsert(10);
//binarySearchTreeLinkedList.RecursiveInsert(40);
//binarySearchTreeLinkedList.RecursiveInsert(60);
//binarySearchTreeLinkedList.RecursiveInsert(90);

//binarySearchTreeLinkedList.IterativeInsert(25);
//binarySearchTreeLinkedList.IterativeInsert(15);
//binarySearchTreeLinkedList.IterativeInsert(35);
//binarySearchTreeLinkedList.IterativeInsert(10);
//binarySearchTreeLinkedList.IterativeInsert(20);
//binarySearchTreeLinkedList.IterativeInsert(30);
//binarySearchTreeLinkedList.IterativeInsert(40);
//binarySearchTreeLinkedList.IterativeInsert(5);
//binarySearchTreeLinkedList.IterativeInsert(12);
//binarySearchTreeLinkedList.IterativeInsert(18);
//binarySearchTreeLinkedList.IterativeInsert(22);
//binarySearchTreeLinkedList.IterativeInsert(28);
//binarySearchTreeLinkedList.IterativeInsert(32);
//binarySearchTreeLinkedList.IterativeInsert(38);
//binarySearchTreeLinkedList.IterativeInsert(42);

//BinarySearchTreeLinkedList<int> binarySearchTreeLinkedList2 = binarySearchTreeLinkedList;



//binarySearchTreeLinkedList.Delete(15);
//binarySearchTreeLinkedList2.DeleteNodeWithBothSubTree(15);
//binarySearchTreeLinkedList.InOrderBinarySearchTree(binarySearchTreeLinkedList._root);
//Console.WriteLine("----");
//binarySearchTreeLinkedList.InOrderBinarySearchTree(binarySearchTreeLinkedList2._root);

//int countOfNumber=binarySearchTreeLinkedList.GetCountOfNumberInBinarySearchTree(binarySearchTreeLinkedList._root);
//Console.WriteLine(countOfNumber);
//int height=binarySearchTreeLinkedList.GetHeightOfBinarysearchTree(binarySearchTreeLinkedList._root);
//Console.WriteLine(height-1);//0dan baslayir deye
//Console.WriteLine("Correct -done");
#endregion


#region Heap

//CustomHeap<int> customHeap = new CustomHeap<int>();
//customHeap.InsertHeapData(25);
//customHeap.InsertHeapData(14);
//customHeap.InsertHeapData(2);
//customHeap.InsertHeapData(20);
//customHeap.InsertHeapData(10);

//Console.WriteLine(customHeap.Max());


//Console.WriteLine(string.Join(" " ,customHeap.Select(r=>r)));
//int[] sortedArray=customHeap.HeapSort(new int[] {63,250,835,947,651,28});
//Console.WriteLine(  );

#endregion


#region Hash
//CustomHash customHash = new CustomHash();

//customHash.InsertHashChain(28);
//customHash.InsertHashChain(15);
//customHash.InsertHashChain(47);
//customHash.InsertHashChain(11);
//customHash.InsertHashChain(78);

//Console.WriteLine("Elementler", customHash);
//Console.WriteLine(customHash.SearchForChain(233));
//Console.WriteLine(customHash.SearchForChain(11));

//customHash.InsertHashLinearProbing(28);
//customHash.InsertHashLinearProbing(15);
//customHash.InsertHashLinearProbing(47);
//customHash.InsertHashLinearProbing(11);
//customHash.InsertHashLinearProbing(21);
//customHash.InsertHashLinearProbing(41);
//customHash.InsertHashLinearProbing(51);
//customHash.InsertHashLinearProbing(61);
//customHash.InsertHashLinearProbing(78);

//Console.WriteLine("Elementler", customHash);
//Console.WriteLine(customHash.SearchForChain(11));

#endregion

#region Graphs

//Graph graph = new Graph(4);

#region Edge list codes



//List<(int, int)> edgeList = new List<(int, int)>
//{
//    (0, 1),
//    (0, 2),
//    (1, 2),
//    (2, 3)
//};

//Console.WriteLine("Edge List:");
//foreach (var edge in edgeList)
//{
//    Console.WriteLine($"{edge.Item1} - {edge.Item2}");
//}

#endregion


#region Adjacency List


//graph.AddEdgeForAdjacencyList(1, 2);

#endregion

#region Adjacency matrix


//Console.WriteLine("Empty Adjaency Matrix :");
//graph.Display();
//Console.WriteLine("--Undirected unweighted graph---");
//graph.InsertEdge(0, 1, 1);
//graph.InsertEdge(0, 2, 1);
//graph.InsertEdge(1, 0, 1);
//graph.InsertEdge(1, 2, 1);
//graph.InsertEdge(2, 0, 1);
//graph.InsertEdge(2, 1, 1);
//graph.InsertEdge(2, 3, 1);
//graph.InsertEdge(3, 2, 1);
//graph.Display();

//Console.WriteLine("--Directed weighted graph---");
//graph.InsertEdge(0, 1, 2);
//graph.InsertEdge(0, 2, 5);
//graph.InsertEdge(1, 2, 29);
//graph.InsertEdge(2, 3, 32);
//graph.Display();
//Console.WriteLine("-----------------------------");
//Console.WriteLine("vertex count : " + graph.VertexCount());
//Console.WriteLine("edge count : " + graph.EdgeCount());
//Console.WriteLine("outdegree(0) count : " + graph.OutDegreeCount(0));
//Console.WriteLine("outdegree(3) count : " + graph.OutDegreeCount(3));
//Console.WriteLine("indegree(2) count : " + graph.InDegreeCount(2));
//Console.WriteLine("indegree(0) count : " + graph.InDegreeCount(0));
//Console.WriteLine("exist edge between 0 and 2 : " + graph.ExistEdge(0, 2));
//Console.WriteLine("exist edge between 1 and 3 : " + graph.ExistEdge(1, 3));
//Console.WriteLine("Edges: ");
//graph.Edges();

//graph.RemoveEdge(2, 3);
//Console.WriteLine("Edges after remove (2,3) edge: ");
//graph.Edges();

//Graph g = new Graph(7);
//g.InsertEdge(0, 1, 1);
//g.InsertEdge(0, 5, 1);
//g.InsertEdge(0, 6, 1);
//g.InsertEdge(1, 0, 1);
//g.InsertEdge(1, 2, 1);
//g.InsertEdge(1, 5, 1);
//g.InsertEdge(1, 6, 1);
//g.InsertEdge(2, 3, 1);
//g.InsertEdge(2, 4, 1);
//g.InsertEdge(2, 6, 1);
//g.InsertEdge(3, 4, 1);
//g.InsertEdge(4, 2, 1);
//g.InsertEdge(4, 5, 1);
//g.InsertEdge(5, 2, 1);
//g.InsertEdge(5, 3, 1);
//g.InsertEdge(6, 3, 1);
//Console.WriteLine("Breadth First Search:");
//g.BreadthFirstSearch(0);
//Console.WriteLine("------------");
//Console.WriteLine("Depth First Search:");
//g.DepthFirstSearch(0);
//Console.ReadKey();

#endregion


#endregion

#endregion

#endregion