//Dynamic Method Selection :
//Define a delegate MathOperation for methods that take two integers and return an integer.
//Write methods for:
    //Addition
    //Subtraction
    //Multiplication
    //Division
//Allow the user to select an operation via console input and invoke the appropriate method using the delegate.

namespace CS_Practise.Question.Delegate
{
    internal class question48
    {
        public delegate int MathOperation(int x, int y);  

        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Subtraction(int x, int y)
        {
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x/y;
        }

        public void DelegatePrac()
        {
            MathOperation? mathopeation = null;

            String choice = "Addition";

            switch (choice)
            {
                case "Addition":
                    mathopeation = Addition;
                    break;
                case "Subtraction":
                    mathopeation = Subtraction;
                    break;
                case "Multiplication":
                    mathopeation = Multiplication;
                    break;
                case "Division":
                    mathopeation = Division;
                    break;
                default :
                    Console.WriteLine($"{choice} is not an option");
                    break;
            }

            int result = mathopeation(4, 5);
            Console.Write($"{choice} : {result}");
        }
    }
}
