using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.Stacks.LinkedListBaseStack
{
    public class StackLinkedList<T> : IEnumerable, IEnumerable<T>
    {
        public int _size = 0;
        public StackLinkedListNode<T>? _headNode;
        public StackLinkedListNode<T>? _tailNode;
        public StackLinkedList()
        {
            _headNode = null;
            _tailNode = null;
        }

        public bool IsEmpty=> _size == 0;

        public void Push(T item)
        {
            StackLinkedListNode<T> newNode=new StackLinkedListNode<T>(item);
            if (IsEmpty)
            {
                _headNode = newNode;
                _tailNode = newNode;
            }
            else
            {
               newNode.Next= _headNode;
               _headNode = newNode;
            }
            _size++;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Empty");
            }
            T lastElement = _headNode.Element;
           _headNode= _headNode.Next;
            _size--;
            return lastElement;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Empty");
            }
            T lastElement = _headNode.Element;
            return lastElement;
        }
        public IEnumerator<T> GetEnumerator()
        {
            StackLinkedListNode<T> current = _headNode;
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
