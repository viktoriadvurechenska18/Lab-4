using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();

            shop.AddProduct(new Product("AirPods", 5000, "Wireless headphones", "Electronics"));
            shop.AddProduct(new Product("video surveillance camera", 10000, "panoramic", "Photo equipment"));
            shop.AddProduct(new Product("laptop", 40000, "playful", "Electronics"));

            shop.AddUser(new User("user1", "password1"));
            shop.AddUser(new User("user2", "password2"));

            var user = shop.Users[0];
            var selectedProducts = new List<Product> { shop.Products[0], shop.Products[1] };
            var quantities = new List<int> { 1, 2 };
            shop.PlaceOrder(user, selectedProducts, quantities);

            var filteredProducts = shop.SearchByPriceRange(200, 10000);
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
