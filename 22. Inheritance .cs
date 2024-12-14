using System;
namespace Cox
{
        // Base Class: Person
        public class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void DisplayPersonInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        // Derived Class: Player
        public class Player : Person
        {
            private string sport;
            private int playerNumber;

            public string Sport
            {
                get { return sport; }
                set { sport = value; }
            }

            public int PlayerNumber
            {
                get { return playerNumber; }
                set { playerNumber = value; }
            }

            public Player(string name, int age, string sport, int playerNumber)
                : base(name, age)
            {
                this.sport = sport;
                this.playerNumber = playerNumber;
            }

            public void DisplayPlayerInfo()
            {
                DisplayPersonInfo();
                Console.WriteLine($"Sport: {Sport}, Player Number: {PlayerNumber}");
            }
        }

        // Derived Class: Employee
        public class Employee : Person
        {
            private string position;
            private double salary;

            public string Position
            {
                get { return position; }
                set { position = value; }
            }

            public double Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public Employee(string name, int age, string position, double salary)
                : base(name, age)
            {
                this.position = position;
                this.salary = salary;
            }

            public void DisplayEmployeeInfo()
            {
                DisplayPersonInfo();
                Console.WriteLine($"Position: {Position}, Salary: {Salary}");
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                Player player = new Player("Messi", 30, "RW", 10);
                player.DisplayPlayerInfo();

                Employee employee = new Employee("Shakib Khan", 30, "Software Engineer", 80000);
                employee.DisplayEmployeeInfo();
                Console.ReadLine();
            }
        }
  }



