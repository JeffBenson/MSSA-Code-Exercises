//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/27/2020

/********************************************************************************************
This project contains the code to create "IndividualWarmUp_BensonJeff07272020".
It is a console application that displays on a console window.

Revisions:N/A
Revision Date:N/A
Revised By:N/A

********************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWarmUp_BensonJeff07272020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", name);

            Console.Clear();
            Console.WriteLine("We will now count to 10.");
            Console.WriteLine("Press Enter to begin counting...\n");
            Console.ReadKey();
            Console.Clear();

            void countToTen()
            {
                int i = 0;
                Console.WriteLine(i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
                Console.WriteLine(++i);
                Console.ReadKey();
            }

            countToTen();

            Console.WriteLine("\nGoodbye!");

            Console.ReadKey();
        }
    }
}
