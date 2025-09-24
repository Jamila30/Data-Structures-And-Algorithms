using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections;
using System;
using System.Drawing;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Linear
{
    public class LinearLinkedList<T>  : IEnumerable<T>, IEnumerable where T : IComparable<T>
    {
        private int _size;

        public LinearLinkedListNode<T>? _headNode;
        public LinearLinkedListNode<T>? _tailNode;

        public LinearLinkedList()
        {
            _size = 0;
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty() => _size == 0;
        public void AddLast(T element)
        {
            LinearLinkedListNode<T> newNode = new LinearLinkedListNode<T>(element);
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
            LinearLinkedListNode<T> newNode = new LinearLinkedListNode<T>(element);
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
            _size++;
        }
        public void AddPosition(T element, int position)
        {
            if (position <= 0 || position >= _size)
            {
                throw new Exception("Invalid Position");
            }
            LinearLinkedListNode<T> newNode = new LinearLinkedListNode<T>(element);
            LinearLinkedListNode<T> prevNode = _headNode;
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

            LinearLinkedListNode<T> tempHeadNodeNext = _headNode.Next;
            _headNode = tempHeadNodeNext;

            if (IsEmpty())
            {
                _tailNode = null;
            }
            _size--;
        }

        public int Search(T searchKey)
        {
            LinearLinkedListNode<T> searchNode= _headNode;
            int index =0;
            while (searchNode!=null)
            {
                if (searchNode.Element.Equals(searchKey))
                {
                    return index;
                }
                searchNode= searchNode.Next; 
                index++;
            }
            return -1;
        }

        public void InsertElementAsSorted(T value)
        {
            LinearLinkedListNode<T> newNode= new LinearLinkedListNode<T>(value);
            if (IsEmpty())
            {
                _headNode=newNode;
            }
            else
            {
                LinearLinkedListNode<T> p= _headNode;
                LinearLinkedListNode<T> q= _headNode;

                while (p != null && p.Element.CompareTo(value)<0)
                {
                    q = p;
                    p = p.Next;
                }
                if (p == _headNode)
                {
                    newNode.Next = _headNode;
                    _headNode = newNode;
                }
                else
                {
                    newNode.Next = q.Next;
                    q.Next = newNode;
                }
            }
            _size++;
        }

        

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }

            int i = 1;
            LinearLinkedListNode<T> currentNode = _headNode;
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
            LinearLinkedListNode<T> currentNode = _headNode;
            while (i < position-1)
            {
                currentNode = currentNode.Next;
                i++;
            }
            LinearLinkedListNode<T> deletedNode = currentNode.Next;
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
            LinearLinkedListNode<T> current = _headNode;
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
