// Show the n-th max integer in an array

namespace CS_Practise.Question.LinQ
{
    internal class question37
    {
        public void SelectTopNRecord()
        {
            int[] nums = [1, 10, 9,4,5,7,6,3,2];

            Array.Sort( nums, (a,b)=> b.CompareTo(a) );

            var maxN = nums.Take(3);

            foreach (var n in maxN)
            {
                Console.WriteLine(n);
            }
        }
    }
}
