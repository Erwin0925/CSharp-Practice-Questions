// Find Longest Word in String
namespace CS_Practise.Question.Basic
{
    internal class question6
    {
        public void GetLongest()
        {
            string str = "guess which is the longest words jordanisblack";
            string[] splitstr = str.Split();
            string longest = "";

            foreach (string str2 in splitstr)
            {
                if (str2.Length > longest.Length)
                {
                    longest = str2;
                }
            }
            Console.Write(longest);
        }
    }
}