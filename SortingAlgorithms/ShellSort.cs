namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class ShellSort
    {
        /* Shell Sort - unSorted arrayi sorted arraya cevirir.
       * Alqoritm: 
       *   1.baslangicda gap=length/2 (bosluq demekdir) ile hesablanir.
       *   2.Baslayiriq ilk elementden gap qeder uzaqdaki elementleri(sag) gapla muqayise edirik.
       *   3.Boyukdurse saga , kicikdirse sola qoyuruq.
       *   4.Arrayin sonuna qeder bele davam edirik.
       *   5.Yeniden gap gotururuk gap=gap/2 ile.
       *   6.Yeni gap qeder mesafede (sag) olan elementleri yoxlayiriq yene kicik ve boyuk yer deyisdirir.
       *   7.gap=0 olana qeder yoxlayiriq.
       *   
       *   https://code-maze.com/shell-sort-csharp/
       * 
       * Big O Notation:  O(n2).
       * Animation for understanding how work this algorithm : https://algostructure.com/sorting/shellsort.php
       */


        public int[] SortArray_Shell(int[] unsortedArray)
        {
            int gap=unsortedArray.Length/2;
            while (gap > 0)
            {
               
                for (int i = gap; i < unsortedArray.Length; i++)
                {
                    var currentKey = unsortedArray[i];
                    while (i >= gap && unsortedArray[i - gap] > currentKey)
                    {
                        unsortedArray[i] = unsortedArray[i - gap];
                        i -= gap;
                    }
                    unsortedArray[i] = currentKey;
                }
                gap = gap / 2;
            }

            return unsortedArray;
        }

       

    }
}
