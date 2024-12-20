// Sort a linkedlist
// Write a program to sort a LinkedList<int> in ascending order.
// Since LinkedList does not support sorting directly, implement a custom algorithm to perform the sort.

namespace CS_Practise.Question.Search_Sort
{
    internal class question29
    {
        public void LinkedlistSort()
        {
            int[] nums = {3, 1, 5, 6, 2};
            LinkedList<int> linkedlist = new LinkedList<int>(nums);

            foreach (int i  in linkedlist)
            {
                Console.Write(i + " ");
            }

            List <int> temp = new List<int> (linkedlist);
            temp.Sort((a,b) => a.CompareTo(b));
            linkedlist.Clear();
            foreach (int i in temp)
            {
                linkedlist.AddLast (i);
            }

            Console.WriteLine();
            foreach (int i in linkedlist)
            {
                Console.Write(i + " ");
            }



        }
    }
}
