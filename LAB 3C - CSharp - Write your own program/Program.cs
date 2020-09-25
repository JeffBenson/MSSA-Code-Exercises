//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         07/30/2020

/********************************************************************************************
This project contains the code to create "LAB_3C___CSharp___Write_your_own_program - Convert Feet to Inches".
It is a console application that displays on a console window.

Revisions:
Revisio Date:

Revised By:

********************************************************************************************/


using System;

namespace LAB_3C___CSharp___Write_your_own_program
{
    class Program
    {
        static void Main(string[] args)
        {
            void tuitionCalculator()
            {
                double yearOnebaseTuition = 6000;
                double percentIncrease = 0.02;


                //double 
                double yearTwoTuition = yearOnebaseTuition * percentIncrease + yearOnebaseTuition;
                double yearThreeTuition = yearTwoTuition * percentIncrease + yearTwoTuition;
                double yearFourTuition = yearThreeTuition * percentIncrease + yearThreeTuition;
                double yearFiveTuition = yearFourTuition * percentIncrease + yearFourTuition;



                Console.WriteLine("For year 1 your tuition will be {0}", yearOnebaseTuition);
                Console.WriteLine("For year 2 your tuition will be {0}", yearTwoTuition);
                Console.WriteLine("For year 3 your tuition will be {0}", yearThreeTuition);
                Console.WriteLine("For year 4 your tuition will be {0}", yearFourTuition);
                Console.WriteLine("For year 5 your tuition will be {0}", yearFiveTuition);

                Console.ReadKey();
            }


            tuitionCalculator();


            Console.ReadKey();
        }
    }
}
