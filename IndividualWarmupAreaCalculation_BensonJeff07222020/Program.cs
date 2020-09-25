//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/22/2020

/********************************************************************************************
This project contains the code to create "Individual Warmup Part 2 07/22/2020.
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

namespace IndividualWarmupAreaCalculation_BensonJeff07222020
{
    class Program
    {
        static void Main(string[] args)
        {
            void rectangleArea()
            {
                Console.WriteLine("Calculate the Area of a Rectangle");
                Console.WriteLine("__________________________________");
                
                Console.WriteLine("\nWhat is the width of your rectangle?");
                int width = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Calculate the Area of a Rectangle");
                Console.WriteLine("__________________________________");
                Console.WriteLine("\nWhat is the length of your rectangle?");
                int length = int.Parse(Console.ReadLine());
                Console.Clear();

                int area = length * width;
                Console.WriteLine("Area of your triangle is: \n{0}", area);
            }


            rectangleArea();
            Console.ReadKey();
        }
    }
}
