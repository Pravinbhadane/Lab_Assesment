using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assesment
{
    internal class Digit_Sum_DivBy3
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int digit;

            while (number > 0)
            {
                digit = number % 10;

               if (digit % 3 == 0)
                {
                    Console.WriteLine(digit);
                }
                number = number / 10;
            }
          
        }
    }
}
