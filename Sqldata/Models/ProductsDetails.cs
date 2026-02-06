using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Sqldata.Models
{
    public class ProductsDetails:DbContext
    {
        public ProductsDetails() : base("ProductsConnection")
        {
        }
        public DbSet<Products> ProductsTable { get; set; }
    }
}