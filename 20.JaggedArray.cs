using System;
namespace Cox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Jagged = new int[3][];
            Jagged[0] = new int[] { 45 };
            Jagged[1] = new int[] { 22, 32 };
            Jagged[2] = new int[] { 34, 22, 12 };

            // We can declare like this also
            int[][] Mat = new int[][]
                {
                   new int[] { 100 },
                   new int[] { 200, 300 },
                };

            for (int i = 0; i < Jagged.Length; i++) // row
            {
                for (int j = 0; j < Jagged[i].Length; j++) // col based on row size
                {
                    Console.Write(Jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Using Foreach");

            foreach (var i in Mat) // Using second array
            { // can use int[] or var because it's array of array
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

                Console.ReadLine();
          
        }

    }
}