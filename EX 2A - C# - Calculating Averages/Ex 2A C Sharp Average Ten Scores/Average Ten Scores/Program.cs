//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/09/2020

/********************************************************************************************
Description: This project contains the code to create "Average of Ten Scores" exercise.
It is a console application that displays on a console window.

Revisions:
Revision Date:

Revised By:

********************************************************************************************/
using System;
using System.ComponentModel;
using System.Linq;


namespace EX_2A_C_Sharp_Average_of_Ten_Scores
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("\nIndividual Student Tracker \n");
            Console.WriteLine("_____________________________________________________________________");
            Console.WriteLine("\nThis program will automatically average the 10 test scores you enter,\nand determine the letter grade.\n");
            Console.WriteLine("\nGrades must be scores from 0-100.\n");
            Console.WriteLine("_____________________________________________________________________");



            Console.WriteLine("\nPlease Enter Test Score # 1: ");
            int intOne = int.Parse(Console.ReadLine());
            while (intOne <= 0 | intOne >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 1: ");
                intOne = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 2: ");
            int intTwo = int.Parse(Console.ReadLine());
            while (intTwo <= 0 | intTwo >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 2: ");
                intTwo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 3: ");
            int intThree = int.Parse(Console.ReadLine());
            while (intThree <= 0 | intThree >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 3: ");
                intThree = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 4: ");
            int intFour = int.Parse(Console.ReadLine());
            while (intFour <= 0 | intFour >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 4: ");
                intFour = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 5: ");
            int intFive = int.Parse(Console.ReadLine());
            while (intFive <= 0 | intFive >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 5: ");
                intFive = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 6: ");
            int intSix = int.Parse(Console.ReadLine());
            while (intSix <= 0 | intSix >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 6: ");
                intSix = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 7: ");
            int intSeven = int.Parse(Console.ReadLine());
            while (intSeven <= 0 | intSeven >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 7: ");
                intSeven = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 8: ");
            int intEight = int.Parse(Console.ReadLine());
            while (intEight <= 0 | intEight >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 8: ");
                intEight = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 9: ");
            int intNine = int.Parse(Console.ReadLine());
            while (intNine <= 0 | intNine >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 9: ");
                intNine = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPlease Enter Test Score # 10: ");
            int intTen = int.Parse(Console.ReadLine());
            while (intTen <= 0 | intTen >= 100)
            {
                Console.WriteLine("\nEntry not valid. Please Enter Test Score # 10: ");
                intTen = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            int sum = intOne + intTwo + intThree + intFour + intFive + intSix + intSeven + intEight + intNine + intTen;
            double avg;
            avg = sum / 10.0;

            Console.WriteLine($"\nYour average is {avg}.");



            //Letter Grades
            // A
            if (avg < 100 & avg > 89)
            {
                Console.WriteLine("\nStudent recieves a A.");
            }

            // B
            else if (avg < 90 & avg > 79)
            {
                Console.WriteLine("\nStudent recieves a B.");

            }

            // C
            else if (avg < 80 & avg > 69)
            {
                Console.WriteLine("\nStudent recieves a C.");

            }

            // D
            else if (avg < 70 & avg > 59)
            {
                Console.WriteLine("\nStudent recieves a D.");
            }

            // F
            else if (avg <= 59)
            {
                Console.WriteLine("Student has failed.");

            }


            //Restart or terminate program with input validation
            string[] restartProgram = { "t", "true", "T", "True" };
            string[] closeProgram = { "f", "false", "F", "False" };

            Console.WriteLine("\nDo you wish to try another student? t/f\n");

            string response = Console.ReadLine();
            if (restartProgram.Contains(response))
            {
               Console.Clear();
               Main(args);
            }
            else if (closeProgram.Contains(response))
            {
               Console.Clear();
               Console.WriteLine("\nThank you for using our software.\nHave a great day!\n");
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid selection.");
                Console.WriteLine("\nThank you for using our software.\nHave a great day!\n");
            }

            //Citation:
            //https://stackoverflow.com/questions/9333116/check-a-list-against-user-input
            //https://stackoverflow.com/questions/53752135/entering-elements-into-an-array-and-checking-to-see-if-the-element-already-exist
        }
    }
}






    