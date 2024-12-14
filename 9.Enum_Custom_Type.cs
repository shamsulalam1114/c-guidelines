//--------- Enum Custop Type---------
using System;

namespace Cox
{

    
    enum ErrorCode : long // Declare an enum with custom underlying type and values using long
    {
        None = 0L,
        NotFound = 404L,
        ServerError = 500L,
        BadRequest = 400L
    }
    class Program
    {

        static void Main(string[] args)
        {
            ErrorCode code = ErrorCode.NotFound;

            Console.WriteLine("Error code is: " + code); // Output: Error code is: NotFound
            Console.WriteLine("Numeric value of error code: " + (long)code);
            // Output: Numeric value of error code: 404
            Console.ReadLine();
        }
    }
}
