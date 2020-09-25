//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/09/2020

/********************************************************************************************
Description: This project contains the code to create "Sum of Numbers Exercise".
It is a console application that displays on a console window.

Revisions:
Revision Date:

Revised By:

********************************************************************************************/
using System;
using System.Security.Cryptography.X509Certificates;

namespace EX_2A_C_Sharp_Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers from 1-100. This program will add them together. \n");

            Console.WriteLine("First input: ");
            int intOne = int.Parse(Console.ReadLine());
            while (intOne <= 0 | intOne >= 100)
            {
                Console.WriteLine("First input: ");
                intOne = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Second input: ");
            int intTwo = int.Parse(Console.ReadLine());
            while (intTwo <= 0 | intTwo >= 100)
            {
                Console.WriteLine("Second input: ");
                intTwo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Third input: ");
            int intThree = int.Parse(Console.ReadLine());
            while (intThree <= 0 | intThree >= 100)
            {
                Console.WriteLine("Third input: ");
                intOne = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fourth input: ");
            int intFour = int.Parse(Console.ReadLine());
            while (intFour <= 0 | intFour >= 100)
            {
                Console.WriteLine("Fourth input: ");
                intFour = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Fifth input: ");
            int intFive = int.Parse(Console.ReadLine());
            while (intFive <= 0 | intFive >= 100)
            {
                Console.WriteLine("Fifth input: ");
                intFive = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sixth input: ");
            int intSix = int.Parse(Console.ReadLine());
            while (intSix <= 0 | intSix >= 100)
            {
                Console.WriteLine("Sixth input: ");
                intSix = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Seventh input: ");
            int intSeven = int.Parse(Console.ReadLine());
            while (intSeven <= 0 | intSeven >= 100)
            {
                Console.WriteLine("Seventh input: ");
                intSeven = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Eighth input: ");
            int intEight = int.Parse(Console.ReadLine());
            while (intEight <= 0 | intEight >= 100)
            {
                Console.WriteLine("Eigth input: ");
                intEight = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ninth input: ");
            int intNine = int.Parse(Console.ReadLine());
            while (intNine <= 0 | intNine >= 100)
            {
                Console.WriteLine("Ninth input: ");
                intNine = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Tenth input: ");
            int intTen = int.Parse(Console.ReadLine());
            while (intTen <= 0 | intTen >= 100)
            {
                Console.WriteLine("Tenth input: ");
                intTen = int.Parse(Console.ReadLine());
            }


            int sum = intOne + intTwo + intThree + intFour + intFive + intSix + intSeven + intEight + intNine + intTen;
            double avg;
            avg = sum / 10.0;

            Console.WriteLine($"Your sum is {sum}.");
            
        }
    }
}
