using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections;
using System;

namespace DataStructuresAndAlgorithms.DataStructures.LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T>,IEnumerable
    {
        private int _size = 0;

        public CustomLinkedListNode<T>? HeadNode;

        public bool IsEmpty() => _size == 0;
        public void Add(T element)
        {
            if (IsEmpty())
            {
                HeadNode = new CustomLinkedListNode<T>(element);
            }
            else
            {
                if (HeadNode != null)
                {
                    CustomLinkedListNode<T> newNode= new CustomLinkedListNode<T>(element);
                }
            };
            _size++;
        }
        //private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        //{
        //    newNode.next = node;
        //    newNode.prev = node.prev;
        //    node.prev!.next = newNode;
        //    node.prev = newNode;
        //    count++;
        //}

        public IEnumerator<T> GetEnumerator()
        {
            CustomLinkedListNode<T> current = HeadNode;
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
