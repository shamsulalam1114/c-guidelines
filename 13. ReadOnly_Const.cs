//------------- Readonly const-----------
using System;

namespace Cox
{

    class Fun
    {
        readonly int a;
        public Fun(int aa) // Constructor 
        {
            this.a = aa;
        }
        public void Display() 
        {
            Console.WriteLine("The readonly value is: " + a);
        }

    }
    class Program
    {
        const int x = 10;
        static void Main(string[] args) {

            Console.WriteLine("The Constant value is: " + x);
            //x = 16 //Not possible because of const

            Fun fun = new Fun(50);
            fun.Display();

            Console.ReadLine();
        }
    } 
}