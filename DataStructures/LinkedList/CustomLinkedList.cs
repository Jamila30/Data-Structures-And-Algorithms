using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections;
using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>, IEnumerable
    {
        private int _size;

        public CustomLinkedListNode<T>? _headNode;
        public CustomLinkedListNode<T>? _tailNode;

        public CustomLinkedList()
        {
            _size = 0;
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty() => _size == 0;
        public void AddLast(T element)
        {
            CustomLinkedListNode<T> newNode = new CustomLinkedListNode<T>(element);
            if (IsEmpty())
            {
                _headNode = newNode;
            }
            else
            {
                _tailNode!.Next = newNode;
            };
            _tailNode = newNode;
            _size++;
        }
        public void AddFirst(T element)
        {
            CustomLinkedListNode<T> newNode = new CustomLinkedListNode<T>(element);
            if (IsEmpty())
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
                newNode.Next = _headNode;
                _headNode = newNode;
            };
            _tailNode = newNode;
            _size++;
        }
        public void AddPosition(T element, int position)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }
            CustomLinkedListNode<T> newNode = new CustomLinkedListNode<T>(element);
            CustomLinkedListNode<T> prevNode = _headNode;
            int i = 1;
            while (i < position - 1)
            {
                prevNode = prevNode.Next;
                i++;
            }
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
            _size++;
        }
       
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                return;
            }

            CustomLinkedListNode<T> tempHeadNodeNext = _headNode.Next;
            _headNode = tempHeadNodeNext;

            if (IsEmpty())
            {
                _tailNode = null;
            }

        }

        public int Search(T searchKey)
        {
            CustomLinkedListNode<T> searchNode= _headNode;
            int i=1;
            int index =0;
            while (i < _size - 1)
            {
                if (searchNode.Element.Equals(searchKey))
                {
                    return index;
                }
                searchNode= searchNode.Next; 
                i++;
                index++;
            }
            return -1;
        }

        public void InsertElementAsSorted(T value)
        {
            CustomLinkedListNode<T> newNode= new CustomLinkedListNode<T>(value);
            if (IsEmpty())
            {
                _headNode=newNode;
            }
            else
            {
                CustomLinkedListNode<T> current= _headNode;

            }
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }

            int i = 1;
            CustomLinkedListNode<T> currentNode = _headNode;
            while (i < _size-1)
            {
                currentNode=currentNode.Next;
                i++;
            }
            currentNode.Next = null;
            _tailNode = currentNode;
            _size--;


            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }

        }

        public void RemoveAny(int position)
        {
            if( position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }

            if (IsEmpty() )
            {
                return;
            }

            int i = 1;
            CustomLinkedListNode<T> currentNode = _headNode;
            while (i < position-1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            CustomLinkedListNode<T> deletedNode = currentNode.Next;
            currentNode.Next = deletedNode.Next;



            _size--;


            if (IsEmpty())
            {
                _headNode = null;
                _tailNode = null;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            CustomLinkedListNode<T> current = _headNode;
            while (current != null)
            {
                yield return current.Element!;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
