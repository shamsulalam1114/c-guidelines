using System;

namespace Cox
{
    class Program
    {

        int x;

        static void Main(String[] args)
        {
            Program pg1 = new Program();
            Program pg2 = pg1;
            int x = 5;
            int y = x;
            Console.WriteLine("value of x: " + x);
            Console.WriteLine("value of y: " + y);
            y = 10;
            Console.WriteLine("After Changing y's value");
            Console.WriteLine("value of x: " + x);
            Console.WriteLine("value of y: " + y);


            pg1.x = 100;
            Console.WriteLine("Value using object 1 : " + pg1.x);
            Console.WriteLine("Value using object 2 : " + pg2.x);
            pg2.x = 200; // Changing value for object 2 and checking does it effect to the object one or not...
            Console.WriteLine("After modifying object 2");
            Console.WriteLine("Value using object 2 : " + pg2.x);
            Console.WriteLine("After changing object 2, printng object 1 : " + pg1.x);

            Console.ReadLine();

        }
    }
}