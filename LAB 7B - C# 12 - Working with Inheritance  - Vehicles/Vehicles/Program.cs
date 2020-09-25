//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         08/15/2020

/********************************************************************************************
This project contains the code to create "LAB 7B - C# 12 - Working with Inheritance ".
It is a console application that displays on a console window.

Revisions:
Revisio Date:

Revised By:

********************************************************************************************/


using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");

            Console.WriteLine();
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");

            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
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
