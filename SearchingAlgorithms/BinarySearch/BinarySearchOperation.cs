namespace DataStructuresAndAlgorithms.SearchingAlgorithms.BinarySearch
{
    public class BinarySearchOperation
    {

        /* Binary Search - Axtarılan elementi sort edilmiş arraydan middle element goturerek tapir.
         * Eger axtarılan element middle elementden böyükdürsə -
         *      artıq, elementi [middleElement,...] aralığında axtarırıq
         * Yox eger axtarılan element middle elementden  kiçikdirsə -
         *      artıq, elementi [...., middleElement] aralığında axtarırıq
         */


        public int FindValue_Recursive(int searchKey, int[] searchArray, int leftBound, int rightBound)
        {
            //int leftBound=0, rightBound = searchArray.Length;
            int middleIndex = (leftBound + rightBound) / 2;
            if (searchArray[middleIndex] == searchKey)
                return middleIndex;
            else if (searchKey <= searchArray[middleIndex])
            {
                rightBound = middleIndex;
                return FindValue_Recursive(searchKey, searchArray, leftBound, rightBound);
            }
            else if (searchKey > searchArray[middleIndex])
            {
                leftBound = middleIndex;
                return FindValue_Recursive(searchKey, searchArray, leftBound, rightBound);
            }
            else
                return -1;

        }
    }
}
