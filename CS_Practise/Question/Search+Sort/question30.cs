// Merge and Sort
// Merge two sorted integer arrays into one sorted array.

namespace CS_Practise.Question.Search_Sort
{
    internal class question30
    {
        public void MergeAndSort()
        {
            int[] arr1 = [9, 4, 2, 6, 7];
            int[] arr2 = [28, 1, 24, 5, 2];

            int[] arr = arr1.Concat(arr2).ToArray();

            Array.Sort(arr);

            Console.Write(String.Join(" ", arr));
        }
    }
}
