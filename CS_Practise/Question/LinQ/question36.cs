// Find the +ve numbers in a range of numbers from (1-12) using two where conditions in LINQ Query.
namespace CS_Practise.Question.LinQ
{
    internal class question36
    {
        public void getPositive()
        {
            int[] nums = [-1, 2, -3, 4, -5, 6, -7, 8, -9, 10];

            List<int> list = new List<int>(nums); 

            var result = list.Where(num => num > 0 && num <12);

            var result2 = from num in nums 
                          where num > 0  
                          where num <12
                          select num;

            foreach ( var item in result )
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
