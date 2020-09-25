//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/27/2020

/********************************************************************************************
This project contains the code to create "Individual_Work_part_3___Different_Operators".
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

namespace Individual_Work_part_3___Different_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Comparison Operators");
            Console.WriteLine("\n_____________________________________________________");

            //Outcomes will be boolean

            int a = 6;
            int b = 2;

            

            Console.WriteLine("\n\nint a = 6;\nint b = 2;\n");

            //       ==
            //Console.WriteLine(a == b); //This statement evaluates to false because it compares a and b. The variables are not equal.
            Console.WriteLine("\nConsole.WriteLine(a == b); \n//This statement evaluates to false because it compares a and b. The variables are not equal.");

            //       !=
            //Console.WriteLine(a != b); //This statement evaluates to true because it compares a and b. The variables are not equal, so it's true. the "!" comparison operator inverts the logic.
            Console.WriteLine("\n\nConsole.WriteLine(a != b); \n//This statement evaluates to true because it compares a and b. The variables are not equal, so it's true. the ! comparison operator inverts the logic.");

            //       >=
            //Console.WriteLine(a >= b); //This statement evaluates to true because it compares a is greater than or equal to b. The variables are not equal.
            Console.WriteLine("\n\nConsole.WriteLine(a >= b); \n//This statement evaluates to true because it compares a is greater than or equal to b. The variables are not equal.");


            //Compound Assignment



            //       /=
            //Console.WriteLine(a /= b); //This statement assigns a the value of a divided by b.
            Console.WriteLine("\n\nConsole.WriteLine(a /= b); \n//This statement assigns a the value of a divided by b.");

            //       *=
            //Console.WriteLine(a *= b); //This statement assigns a the value of a multiplied by b.
            Console.WriteLine("\n\nConsole.WriteLine(a *= b); \n//This statement assigns a the value of a multiplied by b.");



            Console.ReadKey();
        }
    }
}
