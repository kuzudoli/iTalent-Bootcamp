using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class DAL : IDAL
    {
        public static List<Product> Products = new();

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public Boolean Remove(int productId)
        {
            var removeProduct = Products.First(x=>x.id== productId);
            if(removeProduct != null)
                return Products.Remove(removeProduct);
            return false;
        }

        public Boolean Update(Product updateProduct)
        {
            var productIndex = Products.FindIndex(x => x.id == updateProduct.id);
            if(productIndex < 0)
                return false;

            Products[productIndex].name = updateProduct.name;
            Products[productIndex].price = updateProduct.price;

            return true;
        }

        public Product ReadOne(int productId)
        {
            return Products.FirstOrDefault(x => x.id == productId)!;
        }

        public List<Product> ReadList()
        {
            return Products;
        }
    }
}
