using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class Product
    {
        public Product()
        {

        }

        public Product(string name, string barcode, int price, int quantity)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public string Barcode { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
