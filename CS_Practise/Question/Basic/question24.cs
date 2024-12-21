//sort the array in ascending order
namespace CS_Practise.Question.Basic
{
    internal class question24
    {
        public void SortArrAscending()
        {
            int[] numns = { 5, 7, 3, 8, 10, 9 };
            Console.WriteLine($"Original array: {string.Join(", ", numns)}");
            SortAsc(numns);
            Console.WriteLine($"Sorted array: {string.Join(", ", numns)}");
        }

        public static int[] SortAsc(int[] arr)
        {
            Array.Sort(arr, (a, b) => a.CompareTo(b));
            return arr;
            //return Array.Sort(arr) //this is another simplier method
        }
    }
}
