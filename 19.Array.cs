using System;
namespace Cox
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a;
            //int[] b = new int[5];
            //int[] c = new int[5] { 10, 11, 12, 13, 14 };
            //for (int i = 0; i < b.Length; i++)
            //{
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("The array is:");
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write(b[i]+ " ");
            //}
            //Console.WriteLine("By using Foreach");
            //foreach(int aa in b)
            //{ 
            //Console.Write(aa+ " ");
            //}

            // MultiDimension 
            int[,] TwoD = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < TwoD.GetLength(0); i++)
            {
                for (int j = 0; j < TwoD.GetLength(1); j++)
                {
                    Console.Write(TwoD[i,j] + " ");
                }
                Console.WriteLine();
            }
        
            Console.ReadLine();
        }
    }
   
}