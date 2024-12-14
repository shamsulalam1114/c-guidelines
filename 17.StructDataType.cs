// ----- Structure supports value type not reference type -----
using System;

namespace Cox
{
    struct PointStruct
    {
        public int X;
        public int Y;

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"PointStruct({X}, {Y})");
        }
    }

    class Program
    {
        static void Main()
        {
            PointStruct ps1 = new PointStruct(10, 20);
            PointStruct ps2 = ps1; // ps2 is a copy of ps1

            // Display initial values
            Console.WriteLine("Initial values for PointStruct:");
            ps1.Display(); // PointStruct(10, 20)
            ps2.Display(); // PointStruct(10, 20)

            // Modify ps2
            ps2.X = 30;
            ps2.Y = 40;

            // Display values after modification
            Console.WriteLine("After modifying ps2:");
            ps1.Display(); // PointStruct(10, 20) - ps1 remains unchanged
            ps2.Display(); // PointStruct(30, 40)
            Console.ReadLine();
        }
    }
}