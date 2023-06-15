namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };

            // Use LINQ to perform the following operations:
            // 1. Group products by category


            var groupByCategory= from pdt in products
                                 group pdt by pdt.Category into catGrp
                                 select catGrp;
            // 2. Count the number of products in each category
            var productCountsByCategory = from category in groupByCategory
                                          select new { Category = category.Key, Count = category.Count() };

            Console.WriteLine("List of products in each Category");
            foreach (var count in productCountsByCategory)
            {
                Console.WriteLine("{0}: {1}", count.Category, count.Count);
            }
            // 3. Calculate the total price of products in each category
            var totalPriceByCategory = from category in groupByCategory
                                       select new { Category = category.Key, TotalPrice = category.Sum(product => product.Price) };

            Console.WriteLine("Total price of products by category:");
            foreach (var totalPrice in totalPriceByCategory)
            {
                Console.WriteLine("{0}: {1}", totalPrice.Category, totalPrice.TotalPrice);
            }

            // 4. Find the most expensive product in each category
            var mostExpensiveByCategory = from category in groupByCategory
                                          select new { Category = category.Key, MostExpensive = category.OrderByDescending(product => product.Price).FirstOrDefault() };

            Console.WriteLine("Most expensive products by category:");
            foreach (var mostExpensive in mostExpensiveByCategory)
            {
                Console.WriteLine("{0}: {1} ({2:C})", mostExpensive.Category, mostExpensive.MostExpensive.Name, mostExpensive.MostExpensive.Price);
            }

        }
    }
}