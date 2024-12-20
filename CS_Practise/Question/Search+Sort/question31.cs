// Binary Search
// Implement binary search on a sorted array to find a target value.
// Return the index if found, or 1 if not.

namespace CS_Practise.Question.Search_Sort
{
    internal class question31
    {
        public void BinarySearch()
        {
            int[] arr = [28, 1, 24, 5, 2];

            Array.Sort(arr);

            int result1 = Array.BinarySearch(arr,2);
            Console.WriteLine(result1); 

            int result2 = BinarySearch(arr, 2);
            Console.WriteLine(result2);
        }

        public int BinarySearch(int[] arr, int num) 
        {
            int left = 0;
            int right = arr.Length - 1; 

            while (left <= right)
            {
                int mid = (left + right) / 2; 

                if (arr[mid] == num)  
                {
                    return mid;
                }
                else if (arr[mid] < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}


