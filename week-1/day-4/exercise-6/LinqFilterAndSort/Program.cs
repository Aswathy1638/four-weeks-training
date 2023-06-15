namespace LinqFilterAndSort
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Person objects
            List<Person> people = new List<Person>()
            {
                            new Person { FirstName = "akash", LastName = "raj", Age = 16 },
                            new Person { FirstName = "ben", LastName = "dev", Age = 25 },
                            new Person { FirstName = "chin", LastName = "elms", Age = 30 },


            };
            // Use LINQ to filter and sort the list
            var filteredPeople = people.Where(p => p.Age >= 20)
                                   .OrderBy(p => p.LastName)
                                   .ThenBy(p => p.FirstName);
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}");
            }
            // Print the filtered and sorted list of people to the console
        }
    }
}