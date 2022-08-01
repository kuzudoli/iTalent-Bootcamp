using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    interface IDAL
    {
        void Add(Product product);
        Boolean Remove(int productId);
        Boolean Update(Product updateProduct);
        Product ReadOne(int productId);
        List<Product> ReadList();
    }
}
