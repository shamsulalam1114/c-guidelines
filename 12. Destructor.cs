// -------- Destructor-------
using System;

namespace Cox
{
    class MyClass
    {
        public int x; // instance variable
        public int y;
        public static int z; // static variable 

        // Default constructor
        public MyClass()
        {
            Console.WriteLine("Default constructor called.");
        }

        // Parameterized constructor
        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Parameterized constructor called.");
        }

        // Copy constructor
        public MyClass(MyClass obj)
        {
            x = obj.x;
            y = obj.y;
            Console.WriteLine("Copy constructor called.");
        }

        // Static constructor
        static MyClass()
        {
            z = 100; // By default 0
            Console.WriteLine("Static constructor called.");
        }

        // Finalizer (destructor)
        ~MyClass()
        {
            Console.WriteLine("Destructor (Finalizer) called.");
        }

        public void Display()
        {
            Console.WriteLine($"x: {x}, y: {y}, z: {z}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using default constructor
            MyClass obj1 = new MyClass();
            obj1.Display();

            // Using parameterized constructor
            MyClass obj2 = new MyClass(10, 20);
            obj2.Display();

            // Using copy constructor
            MyClass obj3 = new MyClass(obj2);
            obj3.Display();

            // Accessing static member to show static constructor call
            Console.WriteLine($"Static member z: {MyClass.z}");

            // Forcing garbage collection to demonstrate destructor call
            obj1 = null;
            obj2 = null;
            obj3 = null;

            
            
            GC.Collect();
            //This method is useful when you want to immediately reclaim memory that is no longer in use
            GC.WaitForPendingFinalizers();
            //This method ensures that all objects that are ready
            //for finalization have been finalized before the program continues.

            Console.WriteLine("Garbage collection performed.");
            Console.ReadLine();
        }
    }
}
