//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/20/2020

/********************************************************************************************
This project contains the code to create "Individual Warm Up - Part 3 -  07/20/2020".
It is a console application that displays on a console window.

Revisions:              N/A
Revision Date:          N/A

Revised By:             N/A

********************************************************************************************/


using System;

namespace IndividualWarmup_BensonJeff07202020
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string result = p.GetUserDetails(" Jeff Benson", 27);
            Console.WriteLine(result);
            Console.WriteLine("Press Enter Key to Exit...");
            Console.ReadKey();
        }

        public string GetUserDetails(string name, int age)
        {
            string info = string.Format("Name:{0}, Age:{1}", name, age);
            return info;
        }
        
    }
}
