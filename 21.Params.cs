using System;
namespace Cox
{
    class Program
    {
        public int Add(int x,int y)
        {
        return x + y; 
        }

        //Using Params
        //public int Add(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int i in numbers) // using foreach to add n numbers 
        //    {
        //        sum += i;
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
                Program pg = new Program();
                Console.WriteLine(pg.Add(2, 3,4,5,6));
                Console.ReadLine();
          
        }

    }
}