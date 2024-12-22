// create and print a 2D array

namespace CS_Practise.Question.ArrayObject
{
    public class question17
    {
        public void Array2D()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
    }
}