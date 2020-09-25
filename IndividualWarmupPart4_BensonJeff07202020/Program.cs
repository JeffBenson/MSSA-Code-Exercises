//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/20/2020

/********************************************************************************************
This project contains the code to create Individual Warp up Part 4 - 07/20/2020
It is a console application that displays on a console window.

Revisions:
Revision Date:

Revised By:

********************************************************************************************/


using System;

namespace IndividualWarmupPart4_BensonJeff07202020
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserDetails();
            Console.WriteLine("Press Enter Key to Exit...");
            Console.ReadLine();
        }

        public static void GetUserDetails()
        {
            string name = "Jeff Benson";
            int age = 31;

            //The concatenation would work, but string interpolation
            //seems to be more efficient, and easier to read.
            Console.WriteLine("Student Name: {0}, Age: {1}", name, age);
        }
    }
}
