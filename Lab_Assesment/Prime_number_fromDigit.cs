using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assesment
{
    internal class Prime_number_fromDigit
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int digit; bool result;

            while (number > 0)
            {
                digit = number % 10;

             result = PrimeDigit(digit);
                if(result)
                {
                    Console.WriteLine(digit);
                }
                number /= 10;
            }
        }
        public static bool PrimeDigit(int digit)
        {
            
            for (int i = 2; i < digit; i++)
            {
                if(digit % i == 0)
                {
                    return false;
                  
                }
            }
            return true;   
        }
    }
}
