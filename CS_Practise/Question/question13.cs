using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practise.Question
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(String message) : base(message)
        {
        }
    }

    internal class question13
    {
        public void ExceptionT()
        {
            try
            {
                Console.Write("Enter a positive ingeter : ");
                int num = Convert.ToInt32(Console.ReadLine());

                VadidatePositive(num);
                Console.WriteLine($"Your input will be {num}" ); 
            }
            catch (NegativeNumberException ex)
            {
                Console.Write("Error " + ex.Message);
            }
        }

        public void VadidatePositive(int num)
        {
            if (num < 0)
            {
                throw new NegativeNumberException("Negative number is not allowed");
            }
        }
    }
}
