
using System;
namespace Cox
{
    class Test
    {
        protected int x;
    }
    class Program : Test
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.x = 10;
            Console.WriteLine(pg.x);
            //Test tt = new Test(); 
            //tt.x = 20; //Not possible 
            Console.ReadLine();
        }
    }

}




}
