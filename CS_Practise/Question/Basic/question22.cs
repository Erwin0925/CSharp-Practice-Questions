// create linked list using built in method

namespace CS_Practise.Question.Basic
{
    internal class question22
    {
        public void linkedlist()
        {

            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddFirst(4);
            linkedList.AddLast(5);

            foreach (int i in linkedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            linkedList.Remove(3);
            linkedList.RemoveFirst();
            linkedList.RemoveLast();


            foreach (int i in linkedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            LinkedListNode<int> node = linkedList.Find(1);
            if (node != null)
            {
                linkedList.AddAfter(node, 7);
            }

            foreach (int i in linkedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


        }
    }
}
