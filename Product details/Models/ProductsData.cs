using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product_details.Models
{
    public class ProductsData
    {
        public IEnumerable<Products> ProductsList
        {
            get
            {
                List<Products> products = new List<Products>()
                {
                    new Products() { productId = 1, productName = "Laptop", price = 80000 },
                    new Products() { productId = 2, productName = "Smartphone", price = 50000 },
                    new Products() { productId = 3, productName = "Tablet", price = 30000 },
                    new Products() { productId = 4, productName = "Monitor", price = 15000 },
                    new Products() { productId = 5, productName = "Keyboard", price = 2000 },
                };
                return (products);

            }
        }
    }
}