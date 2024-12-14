using System;
namespace Cox
{

    class Program
    {
        static void Main()
        {
            // -------Object------------
            //It can hold any type of data,
            //but requires explicit casting to the appropriate type when accessing the data.
            object a = 10;
            object b = 20;
            object c = "Hello";
            Console.WriteLine(a+ " is "+a.GetType());
            Console.WriteLine(c + " is " + c.GetType());
            //object d = a + b; // It will show error. Because object can't do any arithimetic operation.
            //object d = (int)a + (int)b; // Have to do type casting to do the operation.
            //Console.WriteLine(d);
            object e = 2;
            e = "bye";

            //-----------var------------
            //// Type checking is performed at compile time and the type cannot change.
            //var x = 5;
            //var y = 6;
            //var z = x + y;
            //Console.WriteLine(z);
            ////var y = "Hello"; // Will show error. Cannot implicitly convert type 'int' to 'string;


            //-----------dynamic------------
        //    // dynamic bypasses compile-time type checking. The type is resolved at runtime 
        //    dynamic p = 5;
        //    dynamic q = 3;
        //    dynamic r = "AIUB";
        //    dynamic s = p + q;
        //    p = "Hello";
        //    Console.WriteLine(s.GetType());
        //    Console.WriteLine(r.GetType());
        //    Console.ReadLine();
        }
    }
}