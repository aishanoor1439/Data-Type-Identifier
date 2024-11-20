using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: a single character
            Console.WriteLine("Enter a character: ");
            char inputChar = Convert.ToChar(Console.ReadLine());

            // Check if the character is an alphabet, digit, or special character
            if ((inputChar >= 'a' && inputChar <= 'z') || (inputChar >= 'A' && inputChar <= 'Z'))
            {
                Console.WriteLine($"{inputChar} is an alphabet.");
            }
            else if (inputChar >= '0' && inputChar <= '9')
            {
                Console.WriteLine($"{inputChar} is a digit.");
            }
            else
            {
                Console.WriteLine($"{inputChar} is a special character.");
            }
        }
    }
}
