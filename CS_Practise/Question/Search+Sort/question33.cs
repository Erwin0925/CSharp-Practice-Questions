// Search in LinkedList(manual created linkedlist)
// Create a method to search for a value in a LinkedList<int>.
// The method should return the position of the element or 1 if not found.

namespace CS_Practise.Question.Search_Sort
{
    public class LinklistNode
    {
        public int Data { get; set; }
        public LinklistNode? Next { get; set; } = null;

        public LinklistNode(int data)
        {
            this.Data = data;
            Next = null;
        }
    }

    public class LinkedLists
    {
        LinklistNode? head = null;
        public void AddToBack(int data)
        {
            var node = new LinklistNode(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                LinklistNode? current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public int SearchPosition(int num)
        {
            LinklistNode? current = head;
            int position = 0;
            while (current != null)
            {
                if (current.Data == num)
                {
                    return position;
                }
                current = current.Next;
                position++;
            }
            return -1;
        }
    }

    internal class question33
    {
        public void SearchLinkedList()
        {
            LinkedLists linkedList = new LinkedLists();
            linkedList.AddToBack(3);
            linkedList.AddToBack(5);
            linkedList.AddToBack(12);
            linkedList.AddToBack(7);
            linkedList.AddToBack(44);
            linkedList.AddToBack(23);

            Console.WriteLine(linkedList.SearchPosition(12));

        }
    }
}
