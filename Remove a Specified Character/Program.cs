using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_as_Specified_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method for removing a character from a string
            string remove_char(string str, int n)
            {
                return str.Remove(n, 1);
            }

            Console.WriteLine("Input a word to remove the first letter.");
            Console.WriteLine("\n___________________________________________________\n");
            Console.WriteLine("Please enter a word: ");
            string inputOne = Console.ReadLine();

            Console.WriteLine("\nRemoving 1st letter: \n");
            Console.WriteLine(remove_char(inputOne, 0));

            Console.ReadLine();
        }
    }
}
