namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class InsertionSort
    {
        /* Insertion Sort - unSorted arrayi sorted arraya cevirir.
      * Alqoritm: 
      *   1.2ci elementi gotur, o ilkinden kicikdirse, 1 ci yere qoy
      *   2.3cu elementi gotur, o ilk, ikinciden hansindan boyukdursa onal yer deyisdir
      *   3.bu addimlari array tam siralanmis formaya salinana qeder davam et.
      * 
      * Big O Notation:  O(n2).
      * Animation for understanding how work this algorithm : https://visualgo.net/en/sorting
      *   https://yongdanielliang.github.io/animation/web/InsertionSortNew.html
      */


        public int[] SortArray_Insertion(int[] unSortedArray)
        {
            for (int i = 1; i < unSortedArray.Length; i++)
            {
                int j = i - 1;
                int temp = unSortedArray[i];
                while (j >= 0 && unSortedArray[j]>temp)
                {
                    unSortedArray[j+1] =unSortedArray[j];
                    j--;
                }
                unSortedArray[j+1] = temp;
            }

            return unSortedArray;
        }

      
    }
}
