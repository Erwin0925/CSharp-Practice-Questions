using CS_Practise.Question;
using CS_Practise.Question.ArrayObject;
using CS_Practise.Question.Delegate;
using CS_Practise.Question.Dictionary;
using CS_Practise.Question.Singleton;

namespace CS_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;

            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine($"Are both instances the same? {ReferenceEquals(singleton1, singleton2)}");

            singleton1.DisplayMessage("Go Home ");
        }
    }
}
