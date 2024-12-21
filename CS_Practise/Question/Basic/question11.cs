//Rotate Array Left

namespace CS_Practise.Question.Basic
{
    internal class question11
    {
        public void RotateArry()
        {
            int[] num = [1, 2, 3, 4, 5];

            int temp = num[0];
            num[0] = num[num.Length - 1];
            num[num.Length - 1] = temp;

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
