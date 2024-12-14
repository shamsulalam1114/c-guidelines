//-------------Class value type and reference type---------
// Class supports both value and reference type
using System;

namespace Cox
{
    class PointClass
    {
        public int X;
        public int Y;

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"PointClass({X}, {Y})");
        }
    }

    class Program
    {
        static void Main()
        {
            PointClass pc1 = new PointClass(10, 20);
            PointClass pc2 = pc1; // pc2 is a reference to the same object as pc1

            // Display initial values
            Console.WriteLine("Initial values for PointClass:");
            pc1.Display(); // PointClass(10, 20)
            pc2.Display(); // PointClass(10, 20)

            // Modify pc2
            pc2.X = 30;
            pc2.Y = 40;

            // Display values after modification
            Console.WriteLine("After modifying pc2:");
            pc1.Display(); // PointClass(30, 40) - pc1 is affected because pc1 and pc2 reference the same object
            pc2.Display(); // PointClass(30, 40)
            Console.ReadLine();
        }
    }
}
