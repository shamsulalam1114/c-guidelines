// -------Enum---------
using System;

namespace Cox
{
    enum DaysOfWeek // Declare an enumeration with name DaysOfWeek
    {
        Sunday, // named constant by default value will start from 0 
        Monday, // increased by 1 next = 1
        Tuesday, // 2
        Wednesday, //3
        Thursday, //4
        Friday, //5
        Saturday //6
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Friday;
            //assigns the Friday value from the DaysOfWeek enum to the today variable.
            Console.WriteLine("Today is: " + today); // Output: Today is: Friday
            Console.WriteLine("Numeric value of today: " + (int)today); //convert into number 
            // Output: Numeric value of today: 5
            Console.ReadLine();        }
    }
}
