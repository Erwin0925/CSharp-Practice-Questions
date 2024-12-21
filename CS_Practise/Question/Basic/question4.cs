// Sum of First 500 Primes

namespace CS_Practise.Question.Basic
{
    internal class question4
    {
        public void sumofPrime()
        {
            Console.Write("Sum of prime number from 0 to : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"prime number from 0 to {num}");

            int sum = 0;
            for (int i = 2; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine();
            Console.Write($"Total Sum will be {sum}");
        }
    }
}
