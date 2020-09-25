//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         08/05/2020

/********************************************************************************************
This project contains the code to create "IndividualWarmUp_BensonJeff_08052020".
It is a console application that displays on a console window.

Revisions:
Revision Date:

Revised By:

********************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWarmUp_BensonJeff_08052020
{
    class Program
    {
        public abstract class PublicServant
        {
            public int PensionAmmount { get; set; }
        }

        //Interface for name and age
        public interface IPerson
        {
            string Name { get; set; }
            int Age { get; set; }
        }

        //Firefighter class show inheritence from the PublicServant Abstract Class
        public class Firefighter : PublicServant, IPerson
        {
            public Firefighter(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            //implement interface "IPerson"
            public string Name { get; set; }
            public int Age { get; set; }
        }


        //Emergency fire method
        static void putOutFire()
        {
            Console.WriteLine("How much water pressure is there in numbers?");

            int waterPressure;

            try
            {
                waterPressure = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("No water pressure. Can't put out fire!");
            }
            finally
            {
                Console.WriteLine("Hurry!");
            } 
        }


        static void Main(string[] args)
        {
            //Entering a new Firefighter Name, age, and pension
            Firefighter firefighter = new Firefighter("Joe Robinson", 29);
            firefighter.PensionAmmount = 4500;

            Console.WriteLine(firefighter.Name + " is your newest firefighter.");
            Console.WriteLine("Age: " + firefighter.Age);
            Console.WriteLine("Pension: $" + firefighter.PensionAmmount);

            //Puts out the fire (hopefully)
            putOutFire();

            Console.ReadKey();
        }
    }
}
