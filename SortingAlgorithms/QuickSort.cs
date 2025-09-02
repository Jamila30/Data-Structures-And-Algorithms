namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class QuickSort
    {
        /* Quick Sort - unSorted arrayi sorted arraya cevirir.
         * Alqoritm: 
         *  1.Merge sort-a benzeyir amma tek ferq pivotun olmasidir
         *  2.Pivot secilir ve ona gore sag ve sol sequenceler olur 
         *     ve sequenceleri yeni pivotlara gore bole gedir
         *  3.Yeni pivotdan sagdaki ve soldaki sequenceleri sortlayaraq yigir ve belelikle ,
         *      sonda butun array sirali(sorted) olur
         *  
         * 
         * Big O Notation:  O(n log n).
         * Animation for understanding how work this algorithm : https://yongdanielliang.github.io/animation/web/QuickSortNew.html
         *  https://www.geeksforgeeks.org/dsa/quick-sort-algorithm/
         */


        public int[] SortArray_Quick(int[] unsortedArray,int low, int high)
        {
            if (low < high)
            {

                int pi = partition(unsortedArray, low, high);
                SortArray_Quick(unsortedArray, low, pi - 1);
                SortArray_Quick(unsortedArray, pi + 1, high);
            }
            return unsortedArray;
        }

        private  int partition(int[] arr, int low, int high)
        {

            // hemise bele secmiye de bilersen(meselen lowda sece bilersen)
            int pivot = arr[high];

           
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            // Her seyi yerine qoyduqdan sonra pivotuda yerine qoymaq ucun bele edirem
            swap(arr, i + 1, high);
            return i + 1;
        }

        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
