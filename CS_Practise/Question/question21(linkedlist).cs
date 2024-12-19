//create a linked list manually

using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace CS_Practise.Question
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; } = null;
        public Node(int num)
        {
            this.Data = num;
            Next = null;
        }
    }

    public class LinkedList
    {
        Node? Head = null;

        public void AddToFront(int data)
        {
            var node = new Node(data)
            {
                Next = Head
            };
            Head = node;
        }

        public void AddToBack(int data)
        {
            var node = new Node(data);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public void DeleteNode(int data)
        {
            if (Head == null) return;

            var node = new Node(data);

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
            
        }

        public void Display()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            if (Head == null) return;

            Node? prev = null;
            Node? current = Head;
            Node? next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            Head = prev;
        }
    }
    public class question21
    {
        public void CRUDLinkedList()
        {
            LinkedList list = new LinkedList();
            list.AddToFront(10);
            list.AddToFront(20);
            list.AddToBack(30);
            list.AddToBack(40);
            list.AddToFront(50);
            list.DeleteNode(20);

            list.Display();

            LinkedList list2 = new LinkedList();
            list2.AddToBack(1);
            list2.AddToBack(2);
            list2.AddToBack(3);
            list2.AddToBack(4);
            list2.AddToBack(5);
            list2.Reverse();

            list2.Display();
        }
    }
}

