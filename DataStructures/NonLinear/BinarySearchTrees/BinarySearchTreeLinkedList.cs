using System.Collections;
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
                Console.WriteLine(node.Element);
                InOrderBinarySearchTree(node.RightChild);

            }
        }

       
    }
}

