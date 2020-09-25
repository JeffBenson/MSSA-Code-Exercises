//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/29/2020

/********************************************************************************************
This project contains the code to create "IndividualWarmupWithSwitch_BensonJeff07292020".
It is a console application that displays on a console window.

Revisions:N/A
Revision Date:N/A
Revised By:N/A

********************************************************************************************/


using System;

namespace IndividualWarmup_BensonJeff07292020
{
    class Program
    {
        static void Main(string[] args)
        {
            nameCheck();

            //checks name of user.
            void nameCheck()
            {
                Console.WriteLine("What's your name?");
                string name1 = Console.ReadLine();

                if (name1 == "Christine" || name1 == "christine")
                {
                    Console.Clear();
                    Console.WriteLine("Hello Christine!\nI'm glad it's you, and not a robot....or is it??");
                    Console.ReadKey();
                    roboCheckOne();
                }
                else if (name1 != "Christine")
                {
                    Console.Clear();
                    Console.WriteLine("You're not our instructor. You're a robot inpersonating Christine!");
                    Console.ReadKey();
                    return;
                }
            }

            //first check to see if user is a robot inpersonating christine, because you know...robots.
            void roboCheckOne()
            {
                Console.Clear();
                Console.WriteLine("Alright ChRiStInE, IF that is your real name (ROBOT).");
                Console.WriteLine("What is the real Christine's dog's name?");
                Console.WriteLine("\nI'll give you a hint, it starts with a B. Good luck, robot.");

                string answer = Console.ReadLine();

                if (answer == "Brody" || answer == "brody")
                {
                    Console.Clear();
                    Console.WriteLine("Ok, you win this round, Robot. Next check!");
                    Console.ReadKey();
                    roboCheckTwo();
                }
                else if (answer != "Brody" || answer != "brody")
                {
                    Console.WriteLine("You're not our instructor. You're a robot inpersonating Christine!");
                    Console.ReadKey();
                    return;
                }
            }

            //second check because I don't trust robots.....
            void roboCheckTwo()
            {
                Console.Clear();
                Console.WriteLine("I'm getting tired of this, Robot. Where is CHRISTINE???");
                Console.WriteLine("\nWhat is her Lastname?");
                Console.WriteLine("\nRobots don't have last names, so surely you'll fail this one.");

                string answer = Console.ReadLine();

                if (answer == "Lee" || answer == "lee")
                {
                    Console.Clear();
                    Console.WriteLine("...Christine?");
                    Console.ReadKey();
                    revealingTheTruthMethod();
                }
                else if (answer != "Lee" || answer != "lee")
                {
                    Console.WriteLine("I KNEW IT!!!\nYou're not our instructor.\nYou're a robot inpersonating Christine!");
                    return;
                }
            }

            //The truth
            void revealingTheTruthMethod()
            {
                Console.Clear();
                Console.WriteLine("I can't believe it's really you!");
                Console.WriteLine("\nAre you alright?? Where did the robots take you??");
                Console.WriteLine("\nDo you want to fight the robots?");

                string answer = Console.ReadLine();

                if (answer == "Yes" || answer == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("Ok, I will help you destroy the robots!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n*********************************************");
                    Console.WriteLine("INITIATE ROBODESTROYER MODE");
                    Console.WriteLine("\n*********************************************");
                    Console.ReadKey();
                    //roboCheckThree();
                }
                else if (answer != "Yes" || answer != "yes")
                {
                    Console.WriteLine("...are you sure you're Christine?");
                    Console.ReadKey();
                    return;
                }
            }




            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    roboCheckOne();
                    break;
                case 2:
                    roboCheckTwo();
                    break;
                default:
                    Console.WriteLine("You're not our instructor. You're a robot inpersonating Christine!");
                    break;
            }





            Console.ReadKey();
        }
    }
}
