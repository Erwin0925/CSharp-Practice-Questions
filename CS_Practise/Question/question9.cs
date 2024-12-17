// Uppercase Last Three Characters

namespace CS_Practise.Question 
{
    public class question9
    {
        public void UpperCaseL3()
        {
            Console.WriteLine(UpperCase2("Jordan"));
            Console.WriteLine(UpperCase2("sd"));
            Console.WriteLine(UpperCase2("Chin"));
        }

        public String UpperCase2(String text)
        {
            String result = "";  
            if (text.Length >= 3 )
            {
                result = text.Substring(0,text.Length - 3) +  text.Substring(text.Length - 3, 3).ToUpper();
            } 
            else 
            {
                result = $"{text} is less than 3 character";
            }
            
            return result;
        }
    }
}