using DataStructuresAndAlgorithms.DataStructures.Linear.Queues.LinkedListBaseQueue;
using System.Collections;
using System.Security;
using System.Xml.Linq;

namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.BinarySearchTrees
{
    public class BinarySearchTreeLinkedList<T> where T : IComparable<T>
    {
        private int _size;
        public BinarySearchTreeLinkedListNode<T>? _root;
        public BinarySearchTreeLinkedList()
        {
            _size = 0;
            _root = null;
        }

        public void IterativeInsert(T item)
        {
            BinarySearchTreeLinkedListNode<T> newNode = new BinarySearchTreeLinkedListNode<T>(item);
            BinarySearchTreeLinkedListNode<T> temp = null;
            var troot = _root;
            while (troot != null)
            {
                temp = troot;
                if (item!.Equals(troot.Element))
                {
                    throw new InvalidOperationException("Element of nodes have same value!");
                }
                else if (item.CompareTo(troot.Element) < 0)
                {
                    troot = troot.LeftChild;
                }
                else if (item.CompareTo(troot.Element) > 0)
                {
                    troot = troot.RightChild;
                }
            }
            if (temp != null)
            {
                troot = newNode;
                if (item.CompareTo(temp.Element) < 0)
                {
                    temp.LeftChild = troot;
                }
                else if (item.CompareTo(temp.Element) > 0)
                {
                    temp.RightChild = troot;
                }
                else
                {
                    throw new InvalidOperationException("Element of nodes have same value!");
                }
            }
            else
            {
                _root = newNode;
            }

            _size++;

        }

        //public BinarySearchTreeLinkedListNode<T> RecursiveInsert(T item, BinarySearchTreeLinkedListNode<T>? tempRoot =null )
        //{
        //    BinarySearchTreeLinkedListNode<T> newNode = new BinarySearchTreeLinkedListNode<T>(item);
        //    if(_root == null)
        //    {
        //        _root = newNode;
        //        return newNode;
        //    }

        //    //if (tempRoot != _root) {

        //        if (tempRoot == null)
        //        {
        //            _size++;
        //            tempRoot = newNode;
        //        }
        //        else
        //        {
        //            if (item.CompareTo(tempRoot.Element) < 0)
        //            {
        //                _size++;
        //                tempRoot.LeftChild = RecursiveInsert(item, tempRoot.LeftChild);
        //            }
        //            else if (item.CompareTo(tempRoot.Element) > 0)
        //            {
        //                _size++;
        //                tempRoot.RightChild = RecursiveInsert(item, tempRoot.RightChild);
        //            }
        //            else
        //            {
        //               _root= newNode;
        //            }

        //        }

        //    //else 
        //    //{
        //    //    //_root=newNode;
        //    //    tempRoot = newNode;             
        //    //    RecursiveInsert(item, tempRoot);

        //    //}



        //    _size++;
        //    return tempRoot;
        //}
        public BinarySearchTreeLinkedListNode<T> RecursiveInsert2(T item, BinarySearchTreeLinkedListNode<T>? tempRoot)
        {
            if (tempRoot != null)
            {
                if (item.CompareTo(tempRoot.Element) < 0)
                {
                    tempRoot.LeftChild = RecursiveInsert2(item, tempRoot.LeftChild);
                }
                else if (item.CompareTo(tempRoot.Element) > 0)
                {
                    tempRoot.RightChild = RecursiveInsert2(item, tempRoot.RightChild);
                }
                else
                {
                    throw new InvalidOperationException("item equal to node value");
                }
            }
            else
            {
                BinarySearchTreeLinkedListNode<T> newNode = new BinarySearchTreeLinkedListNode<T>(item);
                tempRoot = newNode;
            }
            _size++;
            return tempRoot;
        }

        public void PreOrderBinarySearchTree(BinarySearchTreeLinkedListNode<T> node = null)
        {
            if (node != null)
            {
                Console.WriteLine(node.Element);
                PreOrderBinarySearchTree(node?.LeftChild);
                PreOrderBinarySearchTree(node.RightChild);

            }
        }

        public void PostOrderBinarySearchTree(BinarySearchTreeLinkedListNode<T> node = null)
        {
            if (node != null)
            {
                PostOrderBinarySearchTree(node?.LeftChild);
                PostOrderBinarySearchTree(node.RightChild);
                Console.WriteLine(node.Element);

            }
        }

        public void InOrderBinarySearchTree(BinarySearchTreeLinkedListNode<T> node = null)
        {
            if (node != null)
            {
                InOrderBinarySearchTree(node?.LeftChild);
                Console.Write(node.Element+ "\t");
                InOrderBinarySearchTree(node.RightChild);

            }
        }

        public void LevelOrderBinarySearchTree()
        {
            Queue<BinarySearchTreeLinkedListNode<T>> binarySearchTreeQueue = new Queue<BinarySearchTreeLinkedListNode<T>>();
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            Console.WriteLine(currentNode.Element);
            binarySearchTreeQueue.Enqueue(currentNode);

            while (binarySearchTreeQueue.Any())
            {
                currentNode = binarySearchTreeQueue.Dequeue();
                if (currentNode.LeftChild != null)
                {
                    Console.WriteLine(currentNode.LeftChild.Element);
                    binarySearchTreeQueue.Enqueue(currentNode.LeftChild);
                }
                if (currentNode.RightChild != null)
                {
                    Console.WriteLine(currentNode.RightChild.Element);
                    binarySearchTreeQueue.Enqueue(currentNode.RightChild);
                }
            }
        }

        public bool Search(T element)
        {
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            while (currentNode != null)
            {
                if (element.CompareTo(currentNode.Element) < 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (element.CompareTo(currentNode.Element) > 0)
                {
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteLeafNode(T element)
        {
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            BinarySearchTreeLinkedListNode<T> parentNode = null;

            while (currentNode != null)
            {

                if (element.CompareTo(currentNode.Element) < 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.LeftChild;
                }
                else if (element.CompareTo(currentNode.Element) > 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    break;
                }

            }
            if (currentNode.LeftChild != null || currentNode.RightChild != null)
            {
                Console.WriteLine("This Is Not Leaf Node");
            }
            else
            {
                if (parentNode.Element.CompareTo(currentNode.Element) < 0)
                {
                    parentNode.RightChild = null;
                }
                else if (parentNode.Element.CompareTo(currentNode.Element) > 0)
                {
                    parentNode.LeftChild = null;
                }
                _size--;
            }
        }

        public void DeleteNodeWithOneSubTree(T element)
        {
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            BinarySearchTreeLinkedListNode<T> parentNode = null;

            while (currentNode != null)
            {

                if (element.CompareTo(currentNode.Element) < 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.LeftChild;
                }
                else if (element.CompareTo(currentNode.Element) > 0)
                {
                    parentNode = currentNode;
                    currentNode = currentNode.RightChild;
                }
                else
                {
                    break;
                }

            }
            if (currentNode.LeftChild != null && currentNode.RightChild != null)
            {
                Console.WriteLine("This method is for deleting node with one subtree!");
                return;
            }
            else if (currentNode.RightChild != null)
            {
                currentNode = currentNode.RightChild;
            }
            else
            {
                currentNode = currentNode.LeftChild;
            }

            if (parentNode.Element.CompareTo(currentNode.Element) < 0)
            {
                parentNode.RightChild = currentNode;
            }
            else if (parentNode.Element.CompareTo(currentNode.Element) > 0)
            {
                parentNode.LeftChild = currentNode;
            }
            _size--;

        }

        /* 
         * Its in-order predecessor (the maximum node in the left subtree), or 
         * Its in-order successor (the minimum node in the right subtree).
          */
        public void DeleteNodeWithBothSubTree(T element)
        {
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            BinarySearchTreeLinkedListNode<T> parentNode = null;

            while (currentNode != null && element.CompareTo(currentNode.Element) != 0)
            {

                parentNode = currentNode;
                if (element.CompareTo(currentNode.Element) < 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (element.CompareTo(currentNode.Element) > 0)
                {
                    currentNode = currentNode.RightChild;
                }

            }

            if (currentNode == null)
                return; // Element tapılmadı
            //Her hansi bir node gotururem meselen right node
            BinarySearchTreeLinkedListNode<T> minRigthLeafNode = currentNode.RightChild;
            BinarySearchTreeLinkedListNode<T> minRigthLeafNodeParent = null;

            while (minRigthLeafNode != null && minRigthLeafNode.LeftChild != null)
            {

                minRigthLeafNodeParent = minRigthLeafNode;
                minRigthLeafNode = minRigthLeafNode.LeftChild;
            }

            minRigthLeafNodeParent.LeftChild = null;
            currentNode.Element = minRigthLeafNode.Element;

            _size--;

        }

        public bool Delete(T element)
        {
            BinarySearchTreeLinkedListNode<T> currentNode = _root;
            BinarySearchTreeLinkedListNode<T> parentNode = null;

            while (currentNode != null && element.CompareTo(currentNode.Element) != 0)
            {

                parentNode = currentNode;
                if (element.CompareTo(currentNode.Element) < 0)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (element.CompareTo(currentNode.Element) > 0)
                {
                    currentNode = currentNode.RightChild;
                }

            }

            if (currentNode == null)
                return false; // Element tapılmadı

            if (currentNode.LeftChild != null && currentNode.RightChild!=null) 
            { 
                BinarySearchTreeLinkedListNode<T> leftSideNode= currentNode.LeftChild;
                BinarySearchTreeLinkedListNode<T> currentNodeCopy = currentNode;
                while (leftSideNode.RightChild != null) 
                {
                    currentNodeCopy = leftSideNode;
                    leftSideNode=leftSideNode.RightChild;
                }
                currentNode.Element = leftSideNode.Element;
                currentNode = leftSideNode;
                parentNode = currentNodeCopy;
            }

            BinarySearchTreeLinkedListNode<T> c = null;
            if(currentNode.LeftChild != null)
            {
                c= currentNode.LeftChild;
            }
            else
            {
                c= currentNode.RightChild;
            }

            if (currentNode == _root)
            {
                _root = null;
            }
            else
            {
                if (currentNode == parentNode.LeftChild)
                {
                    parentNode.LeftChild = c;
                }
                else
                {
                    parentNode.RightChild = c;
                }
            }
            return true;
        }
    }
}

