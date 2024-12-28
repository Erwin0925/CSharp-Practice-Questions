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
            question49 obj1 = question49.Instance;

            obj1.AddData(12);
            obj1.AddData(14);
            obj1.DisplayData();
        }
    }
}
