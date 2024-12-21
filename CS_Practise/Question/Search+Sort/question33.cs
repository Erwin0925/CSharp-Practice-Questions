// Search in LinkedList(manual created linkedlist)
// Create a method to search for a value in a LinkedList<int>.
// The method should return the position of the element or 1 if not found.

namespace CS_Practise.Question.Search_Sort
{
    using CS_Practise.Question.LinkedList;
    public class LinkedlistWithSearch : LinkedList
    {
        public int getIndex(int data)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty");
                return -1;
            }

            int index = 0;
            Node? current = head;
            while (current != null && current.data != data)
            {
                index++;
                current = current.next;
            }

            if (current == null)
            {
                Console.WriteLine("Not Found");
                return -1;
            }

            return index;
        }
    }

    internal class question33
    {
        public void SearchLinkedList()
        {
            LinkedlistWithSearch linkedList = new LinkedlistWithSearch();
            linkedList.InsertBack(3);
            linkedList.InsertBack(5);
            linkedList.InsertBack(12);
            linkedList.InsertBack(7);
            linkedList.InsertBack(44);
            linkedList.InsertBack(23);

            Console.WriteLine(linkedList.getIndex(12));

        }
    }
}
