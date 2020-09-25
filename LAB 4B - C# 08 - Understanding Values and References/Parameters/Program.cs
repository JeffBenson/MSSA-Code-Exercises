//Class:        ERAU ISTA220 Programming Fundamentals
//Student:      Jeff Benson
//Instructor:   Christine E Lee, Instructor
//Date:         08/07/2020

/********************************************************************************************
This project contains the code to create "LAB 4B - C# 08 - Understanding Values and References".
It is a console application that displays on a console window.
********************************************************************************************/


#region using directives

using System;
#endregion

namespace Parameters
{
    class Program
    {
        

        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(ref i);
            Console.WriteLine(i);
            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
