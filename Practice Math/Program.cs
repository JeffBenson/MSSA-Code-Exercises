using System;

namespace Practice_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius Value: ");
            float r = float.Parse(Console.ReadLine());

            float d = 2 * r;

            Console.WriteLine("The diameter is " + d);
        }
    }
}
