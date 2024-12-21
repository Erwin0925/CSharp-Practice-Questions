// craete and dispaly jagged array 

namespace CS_Practise.Question.Basic
{
    public class question18
    {
        public void JaggedArray()
        {
            int[][] arr = new int[2][];

            arr[0] = new int[] { 1, 2, 3, 4, 5 };
            arr[1] = new int[] { 5, 6 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }


        }
    }
}