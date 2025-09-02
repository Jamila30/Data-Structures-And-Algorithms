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
         *   5.Birinci sequenceden 1 ci element, 2 ci seq. 2 ci element gotururu test edir, hansi kicikdise arraya atir
         *   6.Boyuk olan i yada k addim kimi +1 olur.Axira qeder array sort olana qeder bele gedir.
         * 
         * Big O Notation:  O(n log n).
         * Animation for understanding how work this algorithm : https://visualgo.net/en/sorting
         *   https://code-maze.com/csharp-merge-sort/
         */


        //This is from course at udemy , but it doesnt work when array length is so large, it is uncompleted form,
        //completed form is on next lines.
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
                
                int mid = left + (right - left) / 2; 
                SortArray_Merge(unsortedArray, left, mid);  // 
                SortArray_Merge(unsortedArray, mid + 1, right); // 

                MergeArray_Merge(unsortedArray, left, mid, right);
            }

            return unsortedArray;
        }

        public void MergeArray_Merge(int[] unsortedArray, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = unsortedArray[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = unsortedArray[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    unsortedArray[k++] = leftTempArray[i++];
                }
                else
                {
                    unsortedArray[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                unsortedArray[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                unsortedArray[k++] = rightTempArray[j++];
            }
        }

    }
}
