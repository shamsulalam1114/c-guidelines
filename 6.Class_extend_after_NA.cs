using System;

namespace Cox
{
    class Value
    {
        public int x;
        public int y;
    }
    class Program1
    {
        public void add(Value v)
        {
            Console.WriteLine("The sum is : " + (v.x + v.y));
        }
        public void sub(Value v)
        {
            Console.WriteLine("The sub is : " + (v.x - v.y));
        }
    }
    class Program2
    {
       
        public int div(Value v)
        {
            return v.x / v.y;
        }
        public int multi(Value v)
        {
            return v.x * v.y;
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Value v = new Value();
            v.x = 20;
            v.y = 10;

            Program1 pg1 = new Program1();
            Program2 pg2 = new Program2();

            pg1.add(v);
            pg1.sub(v);

            Console.WriteLine("Division result is: " + pg2.div(v));
            Console.WriteLine("Multiplication result is: " + pg2.multi(v));
            Console.ReadLine();
        }

    }
}
