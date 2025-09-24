using DataStructuresAndAlgorithms.DataStructures.Linear.LinkedLists.Linear;

namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.Hashes
{
    public class CustomHash 
    {
        private int _hashSize;
        private LinearLinkedList<int>[] _hashArray;
        private int[] _hashArrayForLinProbing;
        public CustomHash()
        {
            _hashSize = 10;
            _hashArray = new LinearLinkedList<int>[_hashSize];
            _hashArrayForLinProbing = new int[_hashSize];
            for (int i = 0; i < _hashArrayForLinProbing.Length; i++)
            {
                _hashArray[i] = new();
            }
            for (int i = 0; i < _hashArray.Length; i++)
            {
                _hashArray[i] = new LinearLinkedList<int>();
            }
        }

        public int GetHashCodeForChain(int key)
        {
            return (key.GetHashCode()) % _hashSize;
        }

        public bool SearchForChain(int key)
        { 
           int indexCode= GetHashCodeForChain(key);
           return _hashArray[indexCode].Search(key) != -1;
        }
        public void InsertHashChain(int element)
        {

            int currentIndex = GetHashCodeForChain(element);
            LinearLinkedList<int> listOfIndex = _hashArray[currentIndex];
            listOfIndex.InsertElementAsSorted(element);
            
        }

        public int GetHashCodeForLProbing(int key)
        {
            int foundIndex = (key.GetHashCode()) % _hashSize;
            while (_hashArrayForLinProbing[foundIndex] !=0) 
            {
                //Eslinde burda arr[i+j]%10 !=0 while serti  gedir ve novbeti setrde +1 edir,
                //amma men yazanla eyni mentiqe gelir deye bele yazdim
                foundIndex++;
            }
            return foundIndex;
        }

        //Bunu men bele yazdim eyni seye gelir
        public void InsertHashLinearProbing(int element)
        {

            int currentIndex = GetHashCodeForLProbing(element);
             _hashArrayForLinProbing[currentIndex]=(element);          
        }

        public int SearchForLinProbing(int key)
        {
            int indexCode = GetHashCodeForLProbing(key);
            return _hashArrayForLinProbing[indexCode]==0 ? 0 : indexCode;
        }
    }
}
