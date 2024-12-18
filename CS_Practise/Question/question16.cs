// use switch case to display the number of date in a month

using System.Diagnostics;

namespace CS_Practise.Question
{
    public class question16
    {
        public void CheckDay()
        {
            Console.WriteLine("Enter a month : ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1: 
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("29");
                    break;
                default:
                    Console.WriteLine("Please Enter a valid month");
                    break;
            }
        }
    }
}