using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }
        public double TotalPrice { get; set; }
        public string Status { get; set; }

        public Order(List<Product> products, List<int> quantities, string status)
        {
            Products = products;
            Quantities = quantities;
            Status = status;
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                TotalPrice += Products[i].Price * Quantities[i];
            }
        }
    }
}
