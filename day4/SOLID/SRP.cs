using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        private static readonly List<Product> Products;

        public void Add(Product p)
        {
            Products.Add(p);
        }

        public override string ToString()
        {
            return $"{id} ${name}";
        }

        public void CreateOrUpdate(Product p)
        {
            var hasProduct = Products.Any(x => x.id == p.id);
            
            if (!hasProduct)
            {
                Products.Add(p);
                return;
            }

            var productIndex = Products.FindIndex(x=>x.id == p.id);
            Products[productIndex].name = p.name;
                
        }

        public void WriteToConsole()
        {
            Products.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
