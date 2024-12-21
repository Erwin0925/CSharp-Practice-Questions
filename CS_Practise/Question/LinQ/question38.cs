// Show the word that start and end with certain char 
namespace CS_Practise.Question.LinQ
{
    internal class question38
    {
        public void GetWord()
        {
            string[] city = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var result = city.Where(name => name.StartsWith("R") && name.EndsWith("E"));

            foreach (var cityItem in result)
            {
                Console.WriteLine(cityItem);
            }
        }
    }
}
