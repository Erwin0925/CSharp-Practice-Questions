namespace CS_Practise.Question.LinkedList
{
    public class Node
    {
        public int data { get; set; }
        public Node? next { get; set; } = null;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
