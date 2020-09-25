using System;
using System.Collections;
using System.Linq;

namespace Average_a_specific_number_of_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction

            Console.WriteLine("\nIndividual Student Tracker - Any Number of Test Scores \n");

            Console.WriteLine("\n_____________________________________________________________________");

            Console.WriteLine("\n\n\nThis program will automatically average test scores you enter,\nand determine the letter grade.\n");
            Console.WriteLine("\n\nGrades must be scores from 0-100.\n");

            Console.WriteLine("\n_____________________________________________________________________");

            //User enters how many scores they plan to input

            Console.WriteLine("\n\nHow many scores do you wish to enter? ");
            int ScoreCount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //Citation:
            //https://docs.microsoft.com/en-us/dotnet/api/system.console.clear?view=netcore-3.1

            int[] arr = new int[ScoreCount];
            int i;

            Console.Write("\n\nScore Input\n");

            Console.Write("-----------------------------------------\n");

            Console.Write($"Input {ScoreCount} scores: \n");
            Console.WriteLine("");
            for (i = 0; i < ScoreCount; i++)
            {
                Console.Write("Score" +
                    ": ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("\nScores entered are: ");
            for (i = 0; i < ScoreCount; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
            //Citation:
            //https://www.w3resource.com/csharp-exercises/array/csharp-array-exercise-1.php

            int sum = arr.Sum();
            int avg = sum / ScoreCount;
            Console.WriteLine("\nYour average is " + avg);
            //Citation:
            //https://stackoverflow.com/questions/12949907/how-can-i-return-the-sum-average-of-an-int-array


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

            void restartMethod()
            {
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


            restartMethod();


        }
    }
}
