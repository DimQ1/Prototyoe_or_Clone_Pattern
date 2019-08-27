using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human kevin = new Human()
            {
                FirstName = "Kevin",
                LastName = "Hart",
                Nationality = "American",
                City = "Philadelohia",
                State = "PA",
                Country = "USA",
                Father = "Henry",
                Mother = "Nancy",
                School = "George Washington High School",
                Adress = "123 Earth Way",
                Gender = "Male"
            };

            Human robert = kevin.Clone();
            robert.FirstName = "Robert";

            Console.WriteLine($"{kevin.FirstName} {kevin.LastName}");
            Console.WriteLine($"{robert.FirstName} {robert.LastName}");

            Console.ReadKey();

        }
    }
}
