using System;

namespace Cox
{
    
        class Program
        {
        public void Test(int a)
        {
            a = 100;
        }
        static void Main(string[] args)
        {
            Program pg = new Program();
            int a = 20;
            Console.WriteLine("Before calling the method: "+a);
            pg.Test(a);
            Console.WriteLine("Before calling the method: " + a);
            Console.ReadKey();
        }
        }
    
}
