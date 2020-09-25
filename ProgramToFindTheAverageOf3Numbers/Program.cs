using System;

namespace ProgramToFindTheAverageOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, average;
            Console.WriteLine("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            average = (num1 + num2 + num3) / 3;

            Console.Write("Average of three numbers is {0}", average);

            Console.ReadKey();
        }
    }
}
