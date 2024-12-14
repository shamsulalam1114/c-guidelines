using System;

namespace Cox
    {
        class Football
        {
        public virtual void display()
        {
            Console.WriteLine("Football class");
        }

        }
    class Messi: Football
    {
        public override void display()
        {
            base.display();
            Console.WriteLine("Messi Class");
        }
    }
    class Leo : Football
    {
        public override void display()
        {
            Console.WriteLine("Leo class");
        }
    }
     
         class Program
        {
            static void Main(string[] args)
            {

            //Football ft = new Messi();
            //Football ft2 = new Leo();
            //ft.display();
            //ft2.display();

            Football[] ft = new Football[2];
            ft[0] = new Messi();
            ft[1] = new Leo();

            foreach (Football f in ft)
            {
                f.display();
            }

            

           
            

            Console.ReadLine();
            }
        }

    }





