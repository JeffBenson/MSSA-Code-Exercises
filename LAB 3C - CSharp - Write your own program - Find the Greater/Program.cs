//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/31/2020

/********************************************************************************************
This project contains the code to create "LAB 3C - C# - Write your own program - Find the Greater Number".
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

namespace LAB_3C___CSharp___Write_your_own_program___Find_the_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            inputCheck();

            //variable declaration
            float num1;
            float num2;

            //math operations
            findTheGreaterNumber();

            void inputCheck()
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Please enter your first number: ");
                    num1 = float.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Please enter your second number: ");
                    num2 = float.Parse(Console.ReadLine());
                    findTheGreaterNumber();


                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Improper format. Please try again.");
                    Console.ReadKey();
                    inputCheck();
                }
            }
            
            void findTheGreaterNumber()
            {
                if (num1 > num2)
                {
                    Console.Clear();
                    Console.WriteLine("{0} is greater than {1}.", num1, num2);
                    Console.ReadKey();
                }

                else if (num1 < num2)
                {
                    Console.Clear();
                    Console.WriteLine("{0} is less than {1}.", num1, num2);
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Numbers are equal.");
                    Console.ReadKey();
                }
            }
        }
    }
}
