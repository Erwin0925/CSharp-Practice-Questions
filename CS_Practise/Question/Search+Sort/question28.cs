// Sort a linkedlist (manually built linkedlist)
// Write a program to sort a LinkedList<int> in ascending order.
// Since LinkedList does not support sorting directly, implement a custom algorithm to perform the sort.

namespace CS_Practise.Question.Search_Sort
{
    public class Node
    {
        public int data { get; set; }
        public Node? next { get; set; }
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class Linkedlist
    {
        Node? head = null;

        public void AddToBack(int data)
        {
            var node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
            }
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No data stored in linkedlist");
            }
            else
            {
                Node? current = head;
                while (current !=null)
                {
                    Console.Write(current.data + " ");
                    current = current.next; 
                }
            }
        }

        public void Sort()
        {   
            if (head == null)
            {
                Console.WriteLine("No data stored in linkedlist");
            }
            else
            {
                int temp;
                for(Node? i = head; i !=null; i=i.next)
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
            Linkedlist linkedlist = new Linkedlist();
            linkedlist.AddToBack(3);
            linkedlist.AddToBack(1);
            linkedlist.AddToBack(5);
            linkedlist.AddToBack(6);
            linkedlist.AddToBack(2);

            linkedlist.Display();
            Console.WriteLine();
            linkedlist.Sort();
            linkedlist.Display();
        }
    }
}
