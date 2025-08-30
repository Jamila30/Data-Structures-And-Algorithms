namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class SelectionSort
    {

        /* Selection Sort - unSorted arrayi sorted arraya cevirir.
         * Alqoritm: 
         *   1.baslangicda ilk unsorted arraydaki en kicik elementi tap.
         *   2.yeni sorted arrayin ilk elementine menimset.
         *   3.qalan unsorted arraydaki en kicik elementi tap.
         *   4.yeni sorted arrayin novbeti elementine menimset.
         *   5.bu addimlari array tam siralanmis formaya salinana qeder davam et.
         * 
         * Big O Notation:  O(n2).
         * Animation for understanding how work this algorithm : https://liveexample.pearsoncmg.com/liang/animation/web/SelectionSort.html
         */
        public int[] SortArray_Selection(int[] unSortedArray)
        {
            for (int i = 0; i < unSortedArray.Length; i++)
            {
                int minValue = unSortedArray[i];
                int foundIndex = 0;
                int temp = 0;
                for (int j = i + 1; j < unSortedArray.Length; j++)
                {
                    if (minValue >= unSortedArray[j])
                    {
                        minValue = unSortedArray[j];
                        foundIndex = j;
                    }
                }
                if (minValue != unSortedArray[i])
                {

                    temp = unSortedArray[foundIndex];
                    unSortedArray[foundIndex] = unSortedArray[i];
                    unSortedArray[i] = temp;
                }
            }
            return unSortedArray;
        }
    }
}
