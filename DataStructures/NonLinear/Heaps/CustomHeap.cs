using System.Collections;

namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.Heaps
{
    public class CustomHeap<T> :IEnumerable<T>, IEnumerable where T : IComparable<T>
    {
        private int _size;
        private int _maxCapacity;
        private T[] _HeapDatas;
        public CustomHeap()
        {
             _size = 0;
            _maxCapacity = 10;
            _HeapDatas = new T[_maxCapacity];
   
        }

        public bool IsEmpty() { return _size == 0; }
        public int Length { get { return _size; } }

        public void InsertHeapData(T item)
        {
            if (_size == _maxCapacity)
            {
                Console.WriteLine("there is no space for heap");
                return;
            }
             _size++;
            int heapIndex = _size;

            while(item.CompareTo(_HeapDatas[heapIndex/2]) >0 && heapIndex>1) 
            {
                _HeapDatas[heapIndex] = _HeapDatas[heapIndex / 2];
                heapIndex=heapIndex/2;

            }
            _HeapDatas[heapIndex] = item;

        }

        public T Max()
        {
            if(IsEmpty())
            {
                throw new Exception("Heap Array is empty");             
            }
            else
            {
                return _HeapDatas[1];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var data in _HeapDatas)
            {
                yield return data;
            }
        }
    }
}
