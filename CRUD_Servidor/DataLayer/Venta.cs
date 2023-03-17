using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class Venta
    {
        public User User { get; set; }
        public Product Product { get; set; }
        
       

        public Venta(User user , Product product)
        {
            User = user;
            Product = product;
        }

    }
}
