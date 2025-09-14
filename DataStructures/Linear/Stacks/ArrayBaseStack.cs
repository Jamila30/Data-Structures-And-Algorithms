using System;
using System.Collections;
using System.Drawing;

namespace DataStructuresAndAlgorithms.DataStructures.Linear.Stacks
{
    public class ArrayBaseStack<T> :IEnumerable<T> ,IEnumerable
    {
        public int _size = 0;
        public T[] StackArray;
        private int _defaultCapacity = 4;
        public ArrayBaseStack(int capacity)
        {
            StackArray = new T[capacity];
        }

        public ArrayBaseStack()
        {
            StackArray = Array.Empty<T>();
        }

        public bool IsEmpty => _size == 0;
        public int StackLength => StackArray.Length;

        public void Push(T item)
        {
            if (!((uint)_size < (uint)StackArray.Length))
            {
                IncreaseCapacity(_size+1);            
            }
            
            StackArray[_size] = item;
            _size = _size + 1;

        }

        public T Pop()
        {
            
                int size = _size - 1;
                if ((uint)size >= (uint)StackLength)
                {
                    throw new InvalidOperationException("Stack length and size doesnt match");
                }
                T[] newStackArray= StackArray;
                _size = size;

                T lastItem= newStackArray[size];
                newStackArray[size] = default!;
                return lastItem;

        }

        public T Peek()
        {
            int size = _size - 1;
            if ((uint)size >= (uint)StackLength)
            {
                throw new InvalidOperationException("Stack length and size doesnt match");
            }
            T[] newStackArray = StackArray;
            return  newStackArray[size];
        }

        public void IncreaseCapacity(int capacity = 0)
        {
            int newCapacity = StackArray.Length == 0 ? _defaultCapacity : 2*StackArray.Length;
            if(newCapacity> Array.MaxLength)
                newCapacity= Array.MaxLength;
            else if (newCapacity < capacity)
                newCapacity= capacity;

            Array.Resize(ref StackArray, newCapacity);
        }

        public IEnumerator<T> GetEnumerator()
        {
            int i=0;
            T[] newStackArray = StackArray;
            while (i<_size)
            {
                yield return newStackArray[i];
                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
