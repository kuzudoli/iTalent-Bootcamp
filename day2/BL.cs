using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class BL
    {
        private IDAL dal;

        public BL(IDAL _dal)
        {
            dal = _dal;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = dal.GetProducts().Select(x => new Product
            {
                name = x.name,
                price = x.price * 2
            }).ToList();

            return products;
        }

        public void TestMethod()
        {
            //dal.TestMethod();
        }
        
    }
}
