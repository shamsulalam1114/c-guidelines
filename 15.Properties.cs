//---------------Properties-------------
using System;

namespace Cox
{
    class Player
    {
        private int jerseyNumber;
        private string name;

        public Player(int jerseyNumber, string name) // Parameterized Constructor
        {
            JerseyNumber = jerseyNumber;
            Name = name;
        }

        // Property for JerseyNumber
        public int JerseyNumber
        {
            get { return jerseyNumber; }
            set { jerseyNumber = value; }
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Display Function
        public void Display()
        {
            Console.WriteLine("Player name is: " + Name);
            Console.WriteLine("Player Jersey number is: " + JerseyNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player pc = new Player(10,"Messi");
            pc.Display();
            pc.JerseyNumber = 30;
            pc.Name = "Leo";
            pc.Display();
            // Console.WriteLine(pc.Name); // By this also can see the name
            // Console.WriteLine(pc.JerseyNumber);
            Console.ReadLine();
        }
    }
}
