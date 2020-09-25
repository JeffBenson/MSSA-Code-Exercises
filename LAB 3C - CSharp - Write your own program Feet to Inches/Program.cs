//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/30/2020

/********************************************************************************************
This project contains the code to create "LAB_3C___CSharp___Write_your_own_program_Feet_to_Inches".
It is a console application that displays on a console window.

Revisions:
Revisio Date:

Revised By:

********************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3C___CSharp___Write_your_own_program_Feet_to_Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            float feetToConvert;
            inputFeetToInchesConvert();
            


            void inputFeetToInchesConvert()
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("How many feet are there in your measurement?");
                    feetToConvert = float.Parse(Console.ReadLine());
                    conversionToInches();
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Improper format. Please try again.");
                    Console.ReadKey();
                    inputFeetToInchesConvert();
                }
            }
            

            void conversionToInches()
            {
                Console.Clear();
                float conversion = feetToConvert * 12;
                Console.WriteLine("There are {0} inches in {1} feet.", conversion, feetToConvert);
            }

            Console.ReadKey();
        }
    }
}
