using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200 },
            new Product { Id = 2, Name = "T-shirt", Category = "Clothing", Price = 20 },
            new Product { Id = 3, Name = "Chocolate bar", Category = "Food", Price = 2.5 },
            new Product { Id = 4, Name = "Smartphone", Category = "Electronics", Price = 800 },
            new Product { Id = 5, Name = "Jeans", Category = "Clothing", Price = 50 },
            new Product { Id = 6, Name = "Ice cream", Category = "Food", Price = 3 },
            new Product { Id = 7, Name = "Television", Category = "Electronics", Price = 1500 },
            new Product { Id = 8, Name = "Sneakers", Category = "Footwear", Price = 80 },
            new Product { Id = 9, Name = "Stove", Category = "Food", Price = 10 },
            new Product { Id = 10, Name = "Monitor", Category = "Electronics", Price = 300 },
            new Product { Id = 11, Name = "Sweatshirt", Category = "Clothing", Price = 35 },
            new Product { Id = 12, Name = "Book", Category = "Books", Price = 15 },
            new Product { Id = 13, Name = "Bracelet", Category = "Accessories", Price = 25 },
            new Product { Id = 14, Name = "Kettle", Category = "Household appliances", Price = 40 },
            new Product { Id = 15, Name = "Snack bar", Category = "Food", Price = 1.5 },
            new Product { Id = 16, Name = "Mouse", Category = "Electronics", Price = 10 },
            new Product { Id = 17, Name = "Briefcase", Category = "Accessories", Price = 70 },
            new Product { Id = 18, Name = "Sportswear", Category = "Sports", Price = 100 },
            new Product { Id = 19, Name = "Coffee maker", Category = "Household appliances", Price = 60 },
            new Product { Id = 20, Name = "Watch", Category = "Accessories", Price = 120 }
        };

        // 1. Вибрати всі товари з категорії "Електроніка".
        var electronicsProducts = products.Where(p => p.Category == "Electronics");

        // 2. Знайти найдорожчий товар.
        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).First();

        // 3. Підрахувати загальну вартість всіх товарів.
        var totalCost = products.Sum(p => p.Price);

        // 4. Відсортувати товари за ціною у зростаючому порядку.
        var sortedProducts = products.OrderBy(p => p.Price);

        // 5. Вибрати унікальні категорії товарів.
        var uniqueCategories = products.Select(p => p.Category).Distinct();

        // 6. Знайти кількість товарів у кожній категорії.
        var productsCountByCategory = products.GroupBy(p => p.Category)
                                              .ToDictionary(g => g.Key, g => g.Count());

        // 7. Вибрати товари з назвами, які починаються на букву "С".
        var productsStartingWithS = products.Where(p => p.Name.StartsWith("C"));

        // 8. Знайти середню ціну товарів.
        var averagePrice = products.Average(p => p.Price);

        // 9. Вибрати товари, ціна яких менше 50.
        var productsUnder50 = products.Where(p => p.Price < 50);

        // 10. Підрахувати кількість товарів з ціною більше 100.
        var productsOver100Count = products.Count(p => p.Price > 100);

        // 11.Вибрати перші 5 товарів.
        var firstFiveProducts = products.Take(5);

        // 12.Повернути останній товар.
        var lastProduct = products.Last();

        // 13.Вибрати товари з категорії "Їжа" та відсортувати їх за зростанням ціни.
        var foodProductsSortedByPrice = products.Where(p => p.Category == "Food").OrderBy(p => p.Price);

        //Вивід результатів
        Console.WriteLine("All products from the category \"Electronics\":");
        foreach (var product in electronicsProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        Console.WriteLine("\nThe most expensive product:");
        Console.WriteLine($"Name: {mostExpensiveProduct.Name}, Price: {mostExpensiveProduct.Price}");

        Console.WriteLine($"\nTotal cost of all products: {totalCost}");

        Console.WriteLine("\nProducts sorted by price in ascending order:");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        Console.WriteLine("\nUnique product categories:");
        foreach (var category in uniqueCategories)
        {
            Console.WriteLine(category);
        }

        Console.WriteLine("\nNumber of products in each category:");
        foreach (var kvp in productsCountByCategory)
        {
            Console.WriteLine($"Category: {kvp.Key}, Count: {kvp.Value}");
        }

        Console.WriteLine("\nProducts with names starting with the letter \"C\":");
        foreach (var product in productsStartingWithS)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        Console.WriteLine($"\nAverage price of products: {averagePrice}");

        Console.WriteLine("\nProducts with prices less than 50:");
        foreach (var product in productsUnder50)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        Console.WriteLine($"\nNumber of products with prices greater than 100: {productsOver100Count}");

        Console.WriteLine("\nThe first 5 products:");
        foreach (var product in firstFiveProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }

        Console.WriteLine("\nThe last product:");
        Console.WriteLine($"Name: {lastProduct.Name}, Price: {lastProduct.Price}");

        Console.WriteLine("\nFood products sorted by price in ascending order:");
        foreach (var product in foodProductsSortedByPrice)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}
