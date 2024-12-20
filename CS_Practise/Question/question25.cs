// sort the array to let even come before odd
namespace CS_Practise.Question
{
        internal class question25
    {
        public void SortEvenOddArr()
        {
            int[] arr = [12, 16, 24, 23, 15, 26, 34, 21];

            Console.WriteLine(String.Join (",",arr));

            Array.Sort(arr, (a, b) =>
            {
                if (a % 2 == 0 && b % 2 != 0) return -1;
                if (a % 2 != 1 && b % 2 == 0) return 1;
                return a.CompareTo (b);
            });

            Console.WriteLine(String.Join(",", arr));

        }

        public void SortEvenOddLinkedList()
        {
            LinkedList<int> linkedlist = new LinkedList<int>(new[] {12, 16, 24, 23, 15, 26, 34, 21} );

            Console.Write (String.Join (",", linkedlist));
            Console.WriteLine();

            List<int> templist = new List<int>(linkedlist);

            templist.Sort ((a,b) =>
            {
                if (a % 2 == 0 && b % 2 != 0) return -1;
                if (a % 2 != 1 && b % 2 == 0) return 1;
                return a.CompareTo(b);
            });

            linkedlist.Clear();

            foreach (int i in templist)
            {
                linkedlist.AddLast (i); 
            }

            Console.Write(String.Join(",",linkedlist));
        }
    }
}
