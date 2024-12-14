using System;

namespace Cox
{
    class Sports
    {
        private int age;
        private string name;

        public Sports() { } // Default constructor
        public Sports(int age, string name)
        { //Parameterize Constructor
            this.age = age;
            this.name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine(age + " " + name);
        }

        class Cricket : Sports
        {
            private string game;
            public Cricket() { }
            public Cricket(int age, string name, string game) : base(age, name)
            {
                this.game = game;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine(game);
            }

        }

        class Football : Sports
        {
            private string game;
            public Football() { }
            public Football(int age, string name, string game) : base(age, name)
            {
                this.game = game;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine(game);
            }

        }

        class Program
        {
            static void Main(string[] args)
            {

                Sports[] sports = new Sports[2];
                sports[0] = new Cricket(45, "Sachin", "Cricket");
                sports[1] = new Football(37, "Messi", "Football");

                foreach (Sports s in sports) // var s in sports
                {
                    s.Display();
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}





