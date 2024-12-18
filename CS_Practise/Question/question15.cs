// Write a C# program that creates a method that takes a string as input and converts it to uppercase. 
// Handle the NullReferenceException that occurs if the input string is null.

namespace CS_Practise.Question
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message) { }
    }
    public class question15
    {
        public void ExceptionT()
        {
            try
            {
                Console.Write("Enter a words : ");
                string str = Console.ReadLine();
                Console.WriteLine(toUpperCase(str));
            }
            catch (EmptyStringException ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public String toUpperCase(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new EmptyStringException("Please entera word");
            }
            else
            {
                return str.ToUpper();
            }
        }
    }
}