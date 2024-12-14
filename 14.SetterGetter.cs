//-------------Setter Getter----------
using System;

namespace Cox
{

    class Player
    {
        private int JerseyNumber;
        private string name;

        public Player(int jerseyNumber, string name) // Parameterize Constructor
        {
            JerseyNumber = jerseyNumber;
            this.name = name;
        }



        //Setter and Getter for JerseyNumber
        public void SetJersey(int jersey)
        {
            this.JerseyNumber = jersey;
        }
        public int GetJersey()
        {
            return JerseyNumber;
        }

        //Setter and Getter for Name

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        //Display Function
        public void Display()
        {
            Console.WriteLine("Player name is :"+name);
            Console.WriteLine("Player Jersey number is :" + JerseyNumber);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Player pc = new Player(10,"Messi");
            pc.Display();
            pc.SetJersey(30);
            pc.SetName("Leo");
            pc.Display();
            //Console.WriteLine(pc.GetName()); // By this also can see the name
            //Console.WriteLine(pc.GetJersey());
            Console.ReadLine();

        } 
    } 
}