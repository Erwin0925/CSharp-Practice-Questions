// Write a C# Sharp program to print Hello and your name in a separate line.
// Expected Output :
// Hello: Alexandra Abramov

namespace CS_Practise.Question.Basic
{
    public class question1
    {
        public void great()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
        }
    }
}
