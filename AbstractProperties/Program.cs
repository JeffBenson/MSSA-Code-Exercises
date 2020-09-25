using System;

namespace AbstractProperties
{
    class Program
    {
        public abstract class Person
        {
            public abstract string Code
            {
                get;
                set;
            }
            public abstract string Name
            {
                get;
                set;
            }

            public abstract int Age
            {
                get;
                set;
            }

        }

        class Student : Person
        {
            private string code = "N/A";
            private string name = "N/A";
            private int age = 0;

            //Declare a Code property of type string;
            public override string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
                }
            }

            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public override int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public override string ToString()
            {
                return "Code = " + Code + ", Name = " + Name + ", Age = " + Age;
            }

        }

        public static void Main(string[] args)
        {
            Student s = new Student();

            s.Code = "001";
            s.Age = 24;
            s.Name = "Morri";
            Console.WriteLine("Student info: - {0}", s);
            Console.ReadKey();

            s.Age += 1;
            Console.WriteLine("Student info: - {0}", s);
            Console.ReadKey();
        }
    }
}
