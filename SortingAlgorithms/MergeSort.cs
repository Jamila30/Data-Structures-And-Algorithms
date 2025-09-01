using System.Reflection;

namespace DataStructuresAndAlgorithms.SortingAlgorithms
{
    public class MergeSort
    {
        /* Merge Sort - unSorted arrayi sorted arraya cevirir.
         * Alqoritm: 
         *   1.Elementi left , right a gore 2 sequence e bolur
         *   2.Qalan her sequence de [left, mid] ve [mid+1,right] oz ozunde bolune gedir sequencelere 
         *   3.Sonra en asagidan baslayaraq, o sequence-leri sort edir ve birlesdirir
         *   4.Divide and conquer isledir mentiq olaraq
         * 
         * Big O Notation:  O(n log n).
         * Animation for understanding how work this algorithm : https://visualgo.net/en/sorting
         *   https://code-maze.com/csharp-merge-sort/
         */


        //This is from course at udemy , but it doesnt work when array length is so large
        //public int[] SortArray_Merge(int[] unsortedArray, int left, int right, int middle)
        //{

        //    int i = left;
        //    int j = middle + 1;
        //    int k = left;
        //    int[] sortedArray = new int[unsortedArray.Length];
        //    while (i <= middle && j <= right)
        //    {
        //        if (unsortedArray[i] < unsortedArray[j])
        //        {
        //            sortedArray[k] = unsortedArray[i];
        //            i += 1;
        //            k += 1;
        //        }
        //        else
        //        {
        //            sortedArray[k] = unsortedArray[j];
        //            j += 1;
        //            k += 1;
        //        }
        //    }

        //    while (i <= middle)
        //    {

        //        sortedArray[k] = unsortedArray[i];
        //        i += 1;
        //        k += 1;

        //    }
        //    while (j <= right)
        //    {

        //        sortedArray[k] = unsortedArray[j];
        //        j += 1;
        //        k += 1;

        //    }
        //    return sortedArray;
        //}



        // [5,8,2,1,0,9]   l=0 r=5  m=2
        public int[] SortArray_Merge(int[] unsortedArray, int left, int right)
        {
            if (left < right)
            {
                // subsequence de gelende yeni array length ferqli olacaq
                int mid = left + (right - left) / 2;  //2
                SortArray_Merge(unsortedArray, left, mid);  // (arr,0,2)-[5,8,2]-(arr,0,1)
                SortArray_Merge(unsortedArray, mid + 1, right); // (arr,3,4)-[1,0,9]-(arr,2,2)

                MergeArray_Merge(unsortedArray, left, mid, right);
            }
        }

        public int[] MergeArray_Merge(int[] arr,int left, int middle, int right)
        {
        }

    }
}
