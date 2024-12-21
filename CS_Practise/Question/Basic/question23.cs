// Implement a stack with push and pop operations.
// Find the top element of the stack and check if the stack is empty or not.
// FILO

namespace CS_Practise.Question.Basic
{
    internal class question23
    {
        public void Stack()
        {
            Stack<int> IntStack = new Stack<int>();

            IntStack.Push(0);
            IntStack.Push(1);
            IntStack.Push(2);

            Console.Write("Initial Stack : ");
            foreach (int i in IntStack)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.WriteLine($"Top item is : {IntStack.Peek()}");

            Console.WriteLine($"Popped item : {IntStack.Pop()}"); // display the top item and remove from the stack

            Console.Write("IntStack after pop : ");
            foreach (int i in IntStack)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
    }
}
