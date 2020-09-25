//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         08/15/2020

/********************************************************************************************
This project contains the code to create "LAB 7A - C# 11 - Understanding Parameter Arrays ".
It is a console application that displays on a console window.

Revisions:
Revisio Date:

Revised By:

********************************************************************************************/


using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            //Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));
            Console.WriteLine(Util.Sum(2, 4, 6, 8, 10));
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
