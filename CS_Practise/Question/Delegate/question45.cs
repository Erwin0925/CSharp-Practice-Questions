//Define a delegate that can point to a method taking two integers as parameters and returning their sum/sub.

namespace CS_Practise.Question.Delegate
{
    internal class question45
    {
        public delegate void Count(int a, int b);

        public void Sum(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            System.Console.WriteLine(a - b);
        }

        public void DelegatePrac()
        {
            Count getSum = Sum;
            getSum(10, 20);

            Count getSub = Sub;
            getSub(30, 17);
        }
    }
}
