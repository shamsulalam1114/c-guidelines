//---------- All types funcntions in One Class -----------------
using System;

namespace Cox
{
    class Program
    {
        int num1;
        int num2;

        void add() // Non return types
        {
            int add = num1 + num2;
            Console.WriteLine("Sumation result is : " + add);
        }
        int sub() // Return types
        {
            return num1 - num2;
        }
        void multi(int x, int y)
        {
            Console.WriteLine("Multiplication is : " + (x * y));
        }
        int div(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
           Program pg = new Program();
           pg.num1 = 20;
           pg.num2 = 10;
           pg.add();
           Console.WriteLine("Substraction is : " + pg.sub());
           // Or
           //int subtractionResult = pg.sub();
           //Console.WriteLine("Subtraction result is : " + subtractionResult);
           pg.multi(5,5);
           // If want to use the same number: 
           pg.multi(pg.num1, pg.num2);
           int Divresult = pg.div(pg.num1, pg.num2);
           Console.WriteLine("Division answer is: "+ Divresult);
           Console.ReadLine();

        }
    }
}
