// Remove items from list by passing filter

namespace CS_Practise.Question.LinQ
{
    internal class question39
    {
        public void RemoveItem()
        {
            string[] city = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            List<string> list = new List<string>(city);

            list.RemoveAll(item => item.Equals("LONDON"));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
