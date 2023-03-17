using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int id, string name, double price){
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {

        }
        public override string ToString()
        {
            return "ID: " + Id + " | Producto: " + Name + " | Precio: $" + Price;
        }
    }
}
