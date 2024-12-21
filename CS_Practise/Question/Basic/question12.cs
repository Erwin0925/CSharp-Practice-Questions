// Two Consecutive Even or Odd Values

namespace CS_Practise.Question.Basic
{
    internal class question12
    {
        public void CheckB2BEven()
        {
            int[] nums1 = [1, 2, 3, 4, 5, 6];
            Console.WriteLine(B2BEven(nums1));

            List<int> nums2 = new List<int>();
            int[] input = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            nums2.AddRange(input);
            Console.WriteLine(B2BOdd(nums2));
        }

        public bool B2BEven(int[] num)
        {
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] % 2 == 0 && num[i + 1] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool B2BOdd(List<int> num)
        {
            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] % 2 != 0 && num[i + 1] % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
