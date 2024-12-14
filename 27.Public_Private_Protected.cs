using System;

namespace Cox
{
        class AccessModifier
        {
        public int a = 5; // public data
        private int b = 10; // private data
        protected int c = 1; //protected data

        }
        class Program: AccessModifier
        {
        static void Main(string[] args)
        {
            AccessModifier ac = new AccessModifier();
            Console.WriteLine(ac.a);
            //Console.WriteLine(ac.b); // error - can't access private data
            //Console.WriteLine(ac.c); // error - can't access protected data 

            Program pp = new Program();
            Console.WriteLine(pp.c);  // accessing protected data from derived class  
            Console.ReadKey();
        }
        }
    
}
