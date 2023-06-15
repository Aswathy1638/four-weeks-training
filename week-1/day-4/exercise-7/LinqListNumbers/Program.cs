namespace LinqListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Use LINQ to perform the following operations:
            // 1. Find all even numbers
            var evenLinq = from x in numbers
                           where x%2 == 0
                           select x;
            Console.WriteLine("EVEN NUMBERS ARE:");
            foreach (var x in evenLinq)
            {
                Console.WriteLine(x);
            }
            // 2. Find all numbers greater than a specific value (e.g., 20)
            var GreatLinq = from x in numbers
                            where x > 20
                            select x;
            Console.WriteLine("NUMBERS HIGHER THAN 20 ARE:");
            foreach (var x in GreatLinq)
            {
                Console.WriteLine(x);
            }
            // 3. Calculate the sum of all numbers
            var SumLinq = from x in numbers
                          select x;
            int sum = SumLinq.Sum();
            Console.WriteLine($"{sum} is the sum");

            // 4. Calculate the average of all numbers
            var AvgLinq = from x in numbers
                          select x;
            double avg = AvgLinq.Average();
            Console.WriteLine($"{avg} is the average");
            // 5. Find the minimum and maximum values in the list
            var MinMaxLinq= from x in numbers
                             select x;
            int min = MinMaxLinq.Min();
            int max = MinMaxLinq.Max();
            Console.WriteLine($"{min} is the minimum value and {max} is the maximum value");
        }
    }
}