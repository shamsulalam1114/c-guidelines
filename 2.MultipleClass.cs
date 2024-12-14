//All types funcntions in Multiple Class
using System;

namespace Cox
{
    class Program1
    {
        public int x; // By default it's private 
        public int y;
        public void add()
        {
            Console.WriteLine("The sum is : " + (x + y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("The sub is : " + (x - y));
        }
    }
    class Program2
    {
        public int num1, num2;
        public int div()
        {
            return num1 / num2;
        }
        public int multi(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Program1 pg1 = new Program1();
            Program2 pg2 = new Program2();

            pg1.x = 20;
            pg1.y = 10;

            pg2.num1 = 40;
            pg2.num2 = 20;
            pg1.add();
            pg1.sub(pg1.x, pg1.y);
            Console.WriteLine("Division result is: " + pg2.div());
            Console.WriteLine("Multiplication result is: " + pg2.multi(pg2.num1, pg2.num2));
            Console.ReadLine();
        }

    }
}
