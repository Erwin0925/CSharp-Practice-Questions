// Write a C# Sharp program to print the sum of two numbers.

using System.Numerics;

namespace CS_Practise.Question
{
    internal class question2
    {
        public void Sum()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
        }
    }
}
