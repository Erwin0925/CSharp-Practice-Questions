// Sort a linkedlist (manually built linkedlist)
// Write a program to sort a LinkedList<int> in ascending order.
// Since LinkedList does not support sorting directly, implement a custom algorithm to perform the sort.

namespace CS_Practise.Question.Search_Sort
{
    using CS_Practise.Question.LinkedList;
    public class LinkedlistWithSort : LinkedList
    {
        public void Sort()
        {
            if (head == null)
            {
                Console.WriteLine("No data stored in linkedlist");
            }
            else
            {
                int temp;
                for (Node? i = head; i != null; i = i.next)
                {
                    for (Node? j = i.next; j != null; j = j.next)
                    {
                        if (i.data > j.data)
                        {
                            temp = i.data;
                            i.data = j.data;
                            j.data = temp;
                        }
                    }
                }
            }

        }
    }

    internal class question28
    {
        public void SortLinkedList()
        {
            LinkedlistWithSort linkedlist = new LinkedlistWithSort();
            linkedlist.InsertBack(3);
            linkedlist.InsertBack(1);
            linkedlist.InsertBack(5);
            linkedlist.InsertBack(6);
            linkedlist.InsertBack(2);

            linkedlist.Display();
            Console.WriteLine();
            linkedlist.Sort();
            linkedlist.Display();
        }
    }
}
