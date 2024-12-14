/*
Default Constructor ------->
A default constructor is a constructor that doesn't take any parameters. 
It initializes class members to their default values.

Parameterized Constructor ------->
A parameterized constructor takes one or more arguments. 
It allows you to initialize class members to specific values.

Static Constructor ------->
A static constructor is used to initialize static members of the class. 
It is called only once, before any static member is accessed or any instance of the class is created.

Copy Constructor  ------->
A copy constructor creates a new object as a copy of an existing object.

*/


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
            //x = 0; // If we dont declare then also it will show 0 by default 
            //y = 0;
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

            Console.ReadLine();
        }
    }
}
