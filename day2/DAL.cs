using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class DAL:IDAL
    {
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { name = "urun", price = 100 });
            products.Add(new Product { name = "urun2", price = 300 });

            return products;
        }

        public void TestMethod() { }
    }
}
