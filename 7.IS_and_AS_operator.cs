//---------Is and As operator----------
using System;

class Program
{
    static void Main()
    {
        // Example with is operator
        string str1 = "Hello";

        // Check if str1 is of type string using the is operator
        if (str1 is string)
        {
            Console.WriteLine("str1 is a string.");
        }
        else
        {
            Console.WriteLine("str1 is not a string.");
        }

        // Example with as operator
	//object is Universal base types, this include both build in and user define data types. 
        object obj = "World"; 

        // Attempt to cast obj to string using the as operator
        string str2 = obj as string;

        // Check if the cast was successful
        if (str2 != null)
        {
            Console.WriteLine("obj was successfully cast to a string: " + str2);
        }
        else
        {
            Console.WriteLine("obj could not be cast to a string.");
        }
    }
}
