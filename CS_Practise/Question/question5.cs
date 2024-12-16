// Reverse a word | Reverse the sentence of a word

namespace CS_Practise.Question
{
    internal class question5
    {
        public void reverse()
        {
            string str1 = "john";
            string reversestr = new string(str1.Reverse().ToArray());
            Console.WriteLine(reversestr);

            string str2 = "john is walking to the road";
            string[] splitstr = str2.Split(' ');
            Array.Reverse(splitstr);
            string reversedSentence = string.Join(" ", splitstr);
            Console.WriteLine(reversedSentence);
        }
    }
}
