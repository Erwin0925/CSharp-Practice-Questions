// Remove Vowels from String

namespace CS_Practise.Question
{
    public class question8
    {
        public void RemoveVowel()
        {
            string str = "Jordan is black";
            string result = "";

            // Check each character in the string
            foreach (char c in str)
            {
                // Add only non-vowel characters to the result
                if (!"aeiouAEIOU".Contains(c))
                {
                    result += c;
                }
            }

            Console.WriteLine("Original String: " + str);
            Console.WriteLine("String without vowels: " + result);
        }
    }
}