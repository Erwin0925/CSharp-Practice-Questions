// Find Maximum and Minimum
// Find the maximum and minimum values in an integer array without using built-in functions.
namespace CS_Practise.Question.Search_Sort
{
    internal class question32
    {
        public void GetMinMax()
        {
            int[] num = [2, 5, 24, 28, 34, 39, 60, 1];

            Console.WriteLine(getMin(num));
            Console.WriteLine(getMax(num));


        }

        public int getMin(int[] num)
        {
            int left = 0;
            int right = num.Length - 1;
            int Min = num[left];

            while (left <= right)
            {
                if (num[left] < num[right] && Min > num[left])
                {
                    Min = num[left];
                }
                else if (num[right] < num[left] && Min > num[right])
                {
                    Min = num[right];
                }

                left++;
                right--;
            }

            return Min;
        }

        public int getMax(int[] num)
        {
            int left = 0;
            int right = num.Length - 1;
            int Max = num[left];

            while (left <= right)
            {
                if (num[left] > num[right] && Max < num[left])
                {
                    Max = num[left];
                }
                else if (num[right] > num[left] && Max < num[right])
                {
                    Max = num[right];
                }

                left++;
                right--;
            }

            return Max;
        }
    }
}
