//Question: Word Frequency Counter
//Write a program that takes a sentence as input and counts the frequency of each word in the sentence using a Dictionary.
//Requirements:
//The keys in the dictionary should be the words from the sentence.
//The values should be the number of times each word appears.
//Ignore case sensitivity (e.g., "Word" and "word" should be treated as the same).
//Output the word and its frequency in any order.

using System.Text.RegularExpressions;

namespace CS_Practise.Question.Dictionary
{
    internal class question44
    {
        public void DictionaryMedium()
        {
            string str = "This is a test. This test is easy";

            string cleanedSentence = Regex.Replace(str, @"[^\w\s]", "");

            Dictionary<String, int> Counter = new Dictionary<String, int>();

            String[] splitstr = cleanedSentence.ToLower().Split(" ");


            foreach (String str2 in splitstr)
            {
                if (Counter.ContainsKey(str2))
                {
                    Counter[str2] = Counter[str2] + 1;
                }
                else
                {
                    Counter.Add(str2, 1);
                }
            }

            foreach (var count in Counter)
            {
                Console.WriteLine(count.Key + " " + count.Value);
            }
        }

    }
}
