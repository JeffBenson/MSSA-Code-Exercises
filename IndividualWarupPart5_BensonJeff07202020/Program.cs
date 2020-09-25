//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/20/2020

/********************************************************************************************
This project contains the code to create Individual Warp up Part 5 - 07/20/2020
It is a console application that displays on a console window.

Revisions:
Revision Date:

Revised By:

********************************************************************************************/


using System;

namespace IndividualWarupPart5_BensonJeff07202020
{
    class Program
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod();
            MyMethod();

            //Yes, this is a valid statement, although "MyMethod()" should as a 
            //best practice use Camel Case. (   i.e. myMethod()  )

            //It executes MyMethod() 3 times.
        }
    }
}
