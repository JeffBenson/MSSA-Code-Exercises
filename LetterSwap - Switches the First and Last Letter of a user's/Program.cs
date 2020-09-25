using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterSwap___Switches_the_First_and_Last_Letter_of_a_user_s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch the First and Last letter's of a user's input.");
            Console.WriteLine("\n________________________________________________________\n");
            //Method for swapping letters
            string firstLast(string ustr)
            {
                return ustr.Length > 1
                    ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
            }

            Console.WriteLine("Please enter a word: ");

            string input = Console.ReadLine();
            Console.WriteLine(firstLast(input));
            Console.ReadKey();
        }
    }
}
