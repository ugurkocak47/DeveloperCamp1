using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class CartManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congrulations. Added to cart: " + product.Name);
            
        }
        public void Add2(string productName, string description, double price, int inStock) 
        {
            Console.WriteLine("Congrulations. Added to cart: " + productName);
        }

    }
}
