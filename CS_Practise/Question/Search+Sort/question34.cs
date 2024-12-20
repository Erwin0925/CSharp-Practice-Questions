// Search in LinkedList(built in linkedlist)
// Create a method to search for a value in a LinkedList<int>.
// The method should return the position of the element or 1 if not found.
namespace CS_Practise.Question.Search_Sort
{
    internal class question34
    {
        public void SearchLinkedList()
        {
            int[] nums = { 2, 5, 24, 28, 34, 39, 60, 1 };
            LinkedList<int> linkedlist = new LinkedList<int>(nums);

            List<int> list = new List<int>(linkedlist);
            int result = list.BinarySearch(24);
            Console.WriteLine(result);

        }
    }
}
