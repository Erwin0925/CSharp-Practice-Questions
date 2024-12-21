// sort an array of integers in ascending and descending order using:
// bubble sort and quick sort

namespace CS_Practise.Question.Search_Sort
{
    internal class question26
    {
        public void BubbleSort()
        {
            int[] arr = [23, 44, 12, 9, 3, 24, 58, 134, 96, 91];

            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+ 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

            Console.Write(String.Join(", ", arr));
        }
//----------------------------------------------------------------------------------------//
        public void QuickSort()
        {
            int[] arr = { 23, 44, 12, 9, 3, 24, 58, 134, 96, 91 }; // Use curly braces for array initialization
            QuickSortHelper(arr, 0, arr.Length - 1);
            Console.Write(String.Join(",", arr));
        }
        public void QuickSortHelper(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotindex = Partition(arr, left, right);
                QuickSortHelper(arr, left, pivotindex - 1);
                QuickSortHelper(arr, pivotindex + 1, right);
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right]; // Use the value at the right index as the pivot
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot) //if descending ((arr[j] >= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);

            return i + 1;
        }
//----------------------------------------------------------------------------------------//
        public void NormalSort()
        {
            int[] arr = [23, 44, 12, 9, 3, 24, 58, 134, 96, 91];
            
            Array.Sort(arr, (a, b) =>
            {
                return a.CompareTo(b);
            });
            
            Console.Write (String.Join (", ", arr));   

        }
    }
}
