using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._3ShopingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            var products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
            var listOfPeople = new List<Person>();
            var listOfProducts = new List<Product>();
            for (int i = 0; i < people.Count; i++)
            {
                var temp = people[i].Split("=").ToList();
                var currPerson = new Person(temp[0], double.Parse(temp[1]));
                listOfPeople.Add(currPerson);
            }
            for (int i = 0; i < products.Count; i++)
            {
                var temp = products[i].Split("=").ToList();
                var currProduct = new Product(temp[0], double.Parse(temp[1]));
                listOfProducts.Add(currProduct);
            }
            var cmd = Console.ReadLine().Split().ToList();
            while (!cmd.Contains("END"))
            {
                string customerName = cmd[0];
                string productName = cmd[1];
                var currCustomer = listOfPeople.Find(x => x.Name == customerName);
                var currProduct = listOfProducts.Find(x => x.Name == productName);
                if (currCustomer.Money-currProduct.Cost>=0)
                {
                    currCustomer.Products.Add(productName);
                    Console.WriteLine($"{currCustomer.Name} bought {productName}");
                    currCustomer.Money -= currProduct.Cost;
                }
                else
                {
                    Console.WriteLine($"{customerName} can't afford {productName}"); 
                }
                cmd = Console.ReadLine().Split().ToList();
            }
            foreach (var person in listOfPeople)
            {
                if (!person.Products.Any())
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ",person.Products)}");
                }
            }
        }
    }
}
