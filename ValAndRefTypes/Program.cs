using System;

namespace ValAndRefTypes
{
    class Program
    {
        static void ProcessPoint(Point p)
        {
            p.X++;

            Console.WriteLine(p);
        }

        static void ProcessPerson (Person p)
        {
            p.Name = "Barney";
        }


        static void CreateObjects()
        {
            Point p1 = new Point { X = 4, Y = 5 };
            Point p2 = new Point { X = 4, Y = 5 };

            //Console.WriteLine(p1 == p2 ? "Equal" : "Not Equal");

            //Console.WriteLine(p2);

            //p1.X++;
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            Person fred = new Person("Fred");
     
            Person fred2 = fred;

            fred2.Name = "Barney";

            Console.WriteLine(fred.Equals(fred2) ? "Equal" : "Not Equal");

            //Person barney = fred;

            //barney.Name = "Barney";

            //Console.WriteLine(barney);
            //Console.WriteLine(fred);

            //Console.WriteLine(fred.Name);

            //ProcessPerson(fred);

            //Console.WriteLine(fred.Name);
        }

        static void Main()
        {
            CreateObjects();
        }
    }
}
