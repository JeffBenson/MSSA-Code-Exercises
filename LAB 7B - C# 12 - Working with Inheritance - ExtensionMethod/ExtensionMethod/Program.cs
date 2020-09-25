//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         08/15/2020

/********************************************************************************************
This project contains the code to create "LAB 7B - C# 12 - Working with Inheritance - Extension Method".
It is a console application that displays on a console window.

Revisions:
Revisio Date:

Revised By:

********************************************************************************************/


using System;
using Extensions;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            int x = 591;
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
