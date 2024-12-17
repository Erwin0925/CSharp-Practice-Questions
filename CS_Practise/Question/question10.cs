// Sum of Three Integers Ignoring 13 and Right 
namespace CS_Practise.Question
{
    public class question10
    {
        public void SumofInteger()
        {
            int[] num1 = [1, 2, 3];
            int[] num2 = [11, 12, 13];
            Console.WriteLine(Sum(num1));
            Console.WriteLine(Sum(num2));
        }

        public int Sum(int[] num)
        {
            int sum = 0;
            foreach (int i in num)
            {
                if (i !=13)
                {
                    sum += i;
                }
            }
            
            return sum;
        }
    }
}