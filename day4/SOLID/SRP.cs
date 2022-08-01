using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //Single Responsibility Principle
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"{id} ${name}";
        }

    }

    internal class ProductRepository
    {
        private static readonly List<Product> Products;

        public void Add(Product p)
        {
            Products.Add(p);
        }

        public void CreateOrUpdate(Product p)
        {
            var hasProduct = Products.Any(x => x.id == p.id);

            if (!hasProduct)
            {
                Products.Add(p);
                return;
            }

            var productIndex = Products.FindIndex(x => x.id == p.id);
            Products[productIndex].name = p.name;

        }
    }

    internal class ProductPresenter
    {
        public void WriteToConsole(List<Product> Products)
        {
            Products.ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }
    }
}
