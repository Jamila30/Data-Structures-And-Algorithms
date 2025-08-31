namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class BubbleSort
    {
        /* Bubble Sort - unSorted arrayi sorted arraya cevirir.
        * Alqoritm: 
        *   1.baslangicda ilk unsorted arraydaki ilk elementi goturur.
        *   2.Ondan sagdaki ile muqayise edir, boyuk hansidirsa saga kecirir.
        *   3.Her defe 2 element goturur.
        *   4.Bu addimlari array tam siralanmis formaya salinana qeder davam et.
        * 
        * Big O Notation:  O(n2).
        * Animation for understanding how work this algorithm : https://yongdanielliang.github.io/animation/web/BubbleSortNew.html
        */


        public int[] SortArray_Bubble(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length-1; i++)
            {
               
                for (int j = 0; j < unsortedArray.Length-i-1; j++)
                {
                  
                    if ( unsortedArray[j] > unsortedArray[j+1] )
                    {
                        int temp = unsortedArray[j+1];
                        unsortedArray[j+1] = unsortedArray[j]; 
                        unsortedArray[j] = temp;
                    }
                }
            }

            return unsortedArray;
        }

      

    }
}
