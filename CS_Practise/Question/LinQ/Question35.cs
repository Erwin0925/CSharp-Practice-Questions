// Use Linq to check on the array which number will not produce remainder after divided by 2
namespace CS_Practise.Question.LinQ
{
    internal class question35
    {
        public void IsRemainder()
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var evenNumbersMethod = nums.Where(num => num % 2 == 0);
            var evenNumbersQuery = from num in nums where num % 2 == 0 select num;

            foreach (int num in evenNumbersMethod)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            foreach (int num in evenNumbersQuery)
            {
                Console.Write(num + " ");
            }
        }
    }
}
