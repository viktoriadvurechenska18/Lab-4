using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Shop:  ISearchable
    {
        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }
        public List<Order> Orders { get; set; }

        public Shop()
        {
            Products = new List<Product>();
            Users = new List<User>();
            Orders = new List<Order>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void PlaceOrder(User user, List<Product> products, List<int> quantities)
        {
            var order = new Order(products, quantities, "Pending");
            user.PurchaseHistory.Add(order);
            Orders.Add(order);
        }
        public List<Product> SearchByPriceRange(double minPrice, double maxPrice)
        {
            return Products.Where(product => product.Price >= minPrice && product.Price <= maxPrice).ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return Products.Where(product => product.Category == category).ToList();
        }

    }
}
