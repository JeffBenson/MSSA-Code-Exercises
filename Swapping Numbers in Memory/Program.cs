using System;

namespace NumberSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Warmup - Number Swap
            try
            {
                int number1, number2, temp;

                Console.WriteLine("Swapping Numbers in Memory");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("\nInput the First Number: ");
                number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nInput the Second Number: ");
                number2 = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Before Swap:\nNumber1 = {0}\nNumber2 = {1}.", number1, number2);


                //Swap Values
                temp = number1;
                number1 = number2;
                number2 = temp;

                //After Swap
                Console.WriteLine("\n\nAfter swap:\nNumber1 = {0}\nNumber2 = {1}.", number1, number2);

                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("An error has occurred. Exiting now.");
                Console.ReadLine();
            }
        }
    }
}
