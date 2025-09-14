using System.Diagnostics.CodeAnalysis;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.Queues
{
    public class ArrayBaseQueue<T> :IEnumerable<T>,IEnumerable
    {
        private int _size = 0;
        private T[] _arrayQueue;
        private int _head = 0;
        private int _tail = 0;
        private int DefaultCapacity = 4;

        public ArrayBaseQueue()
        {
           _arrayQueue=Array.Empty<T>();   
        }

        public bool IsEmpty() => _size==0;

        //public void Enqueue(T item)
        //{
        //    if((uint)_size==_arrayQueue.Length)
        //    {
        //        IncreaseCapacity(_size+1);
        //    }
        //    _arrayQueue[_tail] = item;
        //    _size++;
        //}

        public void Enqueue(T item)
        {
            if (_size == _arrayQueue.Length)
            {
                Grow(_size + 1);
            }

            _arrayQueue[_tail] = item;
            MoveNext(ref _tail);
            _size++;
        }

        private void SetCapacity(int capacity)
        {
            Debug.Assert(capacity >= _size);
            T[] newarray = new T[capacity];
            if (_size > 0)
            {
                if (_head < _tail)
                {
                    Array.Copy(_arrayQueue, _head, newarray, 0, _size);
                }
                else
                {
                    Array.Copy(_arrayQueue, _head, newarray, 0, _arrayQueue.Length - _head);
                    Array.Copy(_arrayQueue, 0, newarray, _arrayQueue.Length - _head, _tail);
                }
            }

            _arrayQueue = newarray;
            _head = 0;
            _tail = _size == capacity ? 0 : _size;
        }

        private void MoveNext(ref int index)
        {
            int tmp = index + 1;
            if (tmp == _arrayQueue.Length)
            {
                tmp = 0;
            }
            index = tmp;
        }

        private void Grow(int capacity)
        {
            Debug.Assert(_arrayQueue.Length < capacity);

            const int GrowFactor = 2;
            const int MinimumGrow = 4;

            int newcapacity = GrowFactor * _arrayQueue.Length;

            if ((uint)newcapacity > Array.MaxLength) newcapacity = Array.MaxLength;

            newcapacity = Math.Max(newcapacity, _arrayQueue.Length + MinimumGrow);

            if (newcapacity < capacity) newcapacity = capacity;

            SetCapacity(newcapacity);
        }

        public T Dequeue()
        {
            int head = _head;
            T[] array = _arrayQueue;

            if (_size == 0)
            {
                throw new InvalidOperationException();
            }

            T removed = array[head];
            if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            {
                array[head] = default!;
            }
            MoveNext(ref _head);
            _size--;
            return removed;
        }

        //public T Dequeue()
        //{
        //    int size = _size - 1;
        //    if ((uint)size >= (uint)_arrayQueue.Length)
        //    {
        //        throw new InvalidOperationException("Queue length and size doesnt match");
        //    }
        //    T firstValue = _arrayQueue[0];
        //    _size = size;

        //    return firstValue;
        //}


        public T First()
        {
            if ((uint)_size > (uint)_arrayQueue.Length)
            {
                throw new InvalidOperationException("Queue length and size doesnt match");
            }
            T firstValue = _arrayQueue[0];
            return firstValue;
        }
        public int IncreaseCapacity(int capacity=0)
        {
            int newCapacity=  _arrayQueue.Length == 0 ? DefaultCapacity : 2 * _arrayQueue.Length;
            newCapacity= Math.Min(newCapacity, Array.MaxLength);
            newCapacity= Math.Max(newCapacity, capacity);

            Array.Resize(ref _arrayQueue, newCapacity);

            return newCapacity;
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (T item in _arrayQueue)
            {
                yield return item;
            }
        }
    }
}
