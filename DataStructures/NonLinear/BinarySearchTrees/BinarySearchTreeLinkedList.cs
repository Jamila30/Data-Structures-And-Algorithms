using System.Collections;

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

        public void RecursiveInsert(T item, BinarySearchTreeLinkedListNode<T>? troot =null)
        {
            BinarySearchTreeLinkedListNode<T> newNode = new BinarySearchTreeLinkedListNode<T>(item);

            if (troot != null)
            {

            }
            else
            {
                _root=newNode;
            }
        }


    }
}

