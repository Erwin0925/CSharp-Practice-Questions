//Write a C# program that implements a method that takes an array of integers as input and calculates the average value.
//Handle the exception if the array is empty.
namespace CS_Practise.Question.Basic
{
    public class EmptyArrayException : Exception
    {
        public EmptyArrayException(string message) : base(message) { }
    }

    internal class question14
    {
        public void ExceptionT()
        {
            try
            {
                List<int> nums = new List<int>();
                //nums.Add(1);
                //nums.Add(2);
                //nums.Add(3);

                CheckArray(nums);

                foreach (int i in nums)
                {
                    Console.WriteLine(i);
                }
            }
            catch (EmptyArrayException ex)
            {
                Console.Write("Error : " + ex.Message);
            }
        }



        public void CheckArray(List<int> nums)
        {
            if (nums.Count <= 0)
            {
                throw new EmptyArrayException("Array should't be empty");
            }
        }
    }
}
