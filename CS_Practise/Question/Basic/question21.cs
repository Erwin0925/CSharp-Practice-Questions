//create a linked list manually
namespace CS_Practise.Question.Basic
{
    using CS_Practise.Question.LinkedList;
    public class question21
    {
        public void ManualLinkedList()
        {
            var list = new LinkedList(); // Use the correct type from the namespace
            list.InsertBack(2);
            list.InsertBack(3);
            list.InsertBack(4);
            list.InsertBack(5);
            list.InsertFront(7);
            list.InsertFront(9);
            list.DeleteNode(1);

            list.Display();
        }
    }
}

