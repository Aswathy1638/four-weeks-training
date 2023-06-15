namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };


            //Write queries using LINQ for following operations
            //1. Get all people from USA
            //2. Get all people above 30
            //3. Sort people by name
            //4. Project/Select only Name and Country of all people
            var personlinq = from p in people
                              where p.Country == "USA"
                              select p;
            Console.WriteLine("People from USA");

            foreach (var person in personlinq)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("People above 20");

            var personlinq1 = from p in people
                              where p.Age > 20
                              select p;
            foreach (var person in personlinq1)
            {
                Console.WriteLine(person.Name);
            }
            var personlinq2 = people.OrderBy(p => p.Name);
            Console.WriteLine("Sorted  name");
            foreach (var person in personlinq2)
            {
                Console.WriteLine(person.Name);
            }

            var personlinq3 = people.Select(p => new {p.Name,p.Country});

            foreach (var person in personlinq3)
            {
                Console.WriteLine($"{ person.Name} lives in { person.Country}");
            }

        }


    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}