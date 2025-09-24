using DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Linear;

namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.Hashes
{
    public class CustomHash<T> where T : IComparable<T>
    {
        private int _hashSize;
        private LinearLinkedList<T>[] _hashArray;
        public CustomHash()
        {
            _hashSize = 10;
            _hashArray = new LinearLinkedList<T>[_hashSize];
            for (int i = 0; i < _hashArray.Length; i++)
            {
                _hashArray[i] = new LinearLinkedList<T>();
            }
        }

        public int HashCode(T key)
        {
            return Math.Abs(key.GetHashCode()) % _hashSize;
        }
        public int Search(T key) { 
           int indexCode= HashCode(key);
           return _hashArray[indexCode].IsEmpty()? 0 : indexCode;
        }
        public void InsertHashChain(T element)
        {

            int currentIndex = HashCode(element);
            LinearLinkedList<T> listOfIndex = _hashArray[currentIndex];
            listOfIndex.InsertElementAsSorted(element);
            
        }
    }
}
