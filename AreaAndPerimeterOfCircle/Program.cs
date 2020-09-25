using System;

namespace AreaAndPerimeterOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, perimeter, area;
            Console.WriteLine("Please write the radius of your circle: ");
            r = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * 3.14 * r;
            area = 3.14 * Math.Pow(r, 2);
            Console.WriteLine("=================================================");
            Console.WriteLine("The perimeter of your circle is : {0}", perimeter);
            Console.WriteLine("The area of your circle is : {0}", area);
            Console.ReadKey();
        }
    }
}
