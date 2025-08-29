namespace DataStructuresAndAlgorithms.SearchingAlgorithms.LinearSearch
{
    public class LinearSearchOperation
    {
        /* Liner Search - hər dəyəri tək tək yoxlayır. 
         * Big O notation - O(n) =n
         */

        /// <summary>
        /// Method <c>FindValue</c> searching key with iterative liner search algorithm.
        /// <param name="searchKey">the searching key.</param>
        /// <param name="arrayForSearch"> exist array.</param>
        /// </summary>
        public int FindValue_Iterative(int searchKey, int[] arrayForSearch, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                if (arrayForSearch[i] == searchKey)
                {
                    Console.WriteLine("Founded at index :", $"{i}");
                    return i;
                }
                Console.WriteLine($"index checked : {i}, {arrayForSearch[i]}");
            }
            return -1;
        }

        /// <summary>
        /// Method <c>FindValue</c> searching key with recursive liner search algorithm.
        /// <param name="searchKey">  searching key</param>
        /// <param name="arrayForSearch"> exist array</param>
        /// </summary>
        public int FindValue_Recursive(int searchKey, int[] arrayForSearch, int arrayLength)
        {
            if (arrayLength == 0)
                return -1;
            else if (arrayForSearch[arrayLength - 1] == searchKey)
            {
                Console.WriteLine("Founded at index :", $"{(arrayLength-1)}");
                return arrayLength - 1;
            }
            else
            {
                Console.WriteLine("index checked :", (arrayLength - 1).ToString());
                return FindValue_Recursive(searchKey, arrayForSearch, arrayLength - 1);
            }
        }
    }
}
