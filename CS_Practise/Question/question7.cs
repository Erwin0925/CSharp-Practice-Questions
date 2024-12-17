namespace CS_Practise.Question
{
    public class question7
    {
        public void Arraymultiplication()
        {
            int[] arr1 = [1,2,3,4,5];
            int[] arr2 = [2,4,6,8,10];

            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr1[i] * arr2[i]; 
            }

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }
        }
    }
}
