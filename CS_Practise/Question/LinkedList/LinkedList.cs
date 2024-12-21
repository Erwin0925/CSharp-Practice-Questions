namespace CS_Practise.Question.LinkedList
{
    public class LinkedList
    {
        public Node? head = null;

        public void InsertBack(int data)
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

        public void InsertFront(int data)
        {
            var node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next = head; // this is the part to link the new node's next to the head so that the head is always the head. 
                head = node;
            }
        }

        public void DeleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty");
                return;
            }

            if (head.data == data)
            {
                head = head.next;
                return;
            }
            else
            {
                Node current = head;
                while (current.next != null && current.next.data != data )
                {
                    current = current.next;
                }

                if (current.next == null)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    current.next = current.next.next;
                }
            }

        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty");
            }
            else
            {
                Node? current = head;
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
            }
        }
    }
}
