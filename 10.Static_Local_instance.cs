// ------Static Local and Instance---------
using System;

namespace Cox
{

    class Fun
    {
        public int a; // instance variable
        public static int b; // static variable
    }
    class Program
    {

        static void Main(string[] args)
        {
            int x = 10; //Local variable
            Console.WriteLine("Printing Local Variable: " + x); // Printing local variable 

            // Creating two object for Fun class
            Fun f1 = new Fun();
            Fun f2 = new Fun();
            f1.a = 1000; // Assigning value for instance variable from f1 object
            f2.a = 2000; // Assigning value for instance variable from f2 object

            Console.WriteLine("Instance variable value for object 1: " + (f1.a));
            Console.WriteLine("Instance variable value for object 2: " + (f2.a));
            Console.WriteLine("Checking instance value for object 1, Does it changed or not");
            Console.WriteLine("Instance variable value for object 1: " + (f1.a));

            Fun.b = 5000; // Assigning value for static variable, it will copy the same for all.
            Console.WriteLine("Static value: " + Fun.b);

            Console.ReadLine();
        }
    }
}
