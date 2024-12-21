// Uppercase Last Three Characters

namespace CS_Practise.Question.Basic
{
    public class question9
    {
        public void UpperCaseL3()
        {
            Console.WriteLine(UpperCase2("Jordan"));
            Console.WriteLine(UpperCase2("sd"));
            Console.WriteLine(UpperCase2("Chin"));
        }

        public string UpperCase2(string text)
        {
            string result = "";
            if (text.Length >= 3)
            {
                result = text.Substring(0, text.Length - 3) + text.Substring(text.Length - 3, 3).ToUpper();
            }
            else
            {
                result = $"{text} is less than 3 character";
            }

            return result;
        }
    }
}