using System;

namespace Cox
    {
    class Poly
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void add(params int [] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
        class Program 
        {
            static void Main(string[] args)
            {
                Poly pl = new Poly();
            pl.add(1, 2);
            pl.add(1, 2, 3, 4);
            Console.ReadLine();
            }
        }

    }





