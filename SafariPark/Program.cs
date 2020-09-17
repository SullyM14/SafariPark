using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person cathy = new Person("Cathy", "French");
            //Console.WriteLine(cathy.GetFullName());
            //Person nish;
            //nish = new Person("Nish", "Mandal");
            //Console.WriteLine(nish.GetFullName());
            //cathy.Age = 22;
            //Console.WriteLine($"Cathy is {cathy.Age}");
            //cathy.Age = -3;
            //Console.WriteLine($"Cathy is {cathy.Age}");

            //Hunter h = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());

            //Hunter h2 = new Hunter();
            //Console.WriteLine(h2.Shoot());

            //var h3 = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            //Console.WriteLine($"h Equals h3? {h.Equals(h3)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h:{h}");

            Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            a.Ascend(500);
            Console.WriteLine(a.Move(3));
            Console.WriteLine(a);
            a.Descend(200);
            Console.WriteLine(a.Move());
            a.Move();
            Console.WriteLine(a);
        }
    }
}
