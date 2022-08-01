using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class BL
    {
        private IDAL _dal;

        public BL(IDAL dal)
        {
            _dal = dal;
        }

        //Events
        public event Action<int> DownThresholdEvent;
        public event Action<int> UpThresholdEvent;

        //CRUD
        public void AddProduct(Product product)
        {
            _dal.Add(product);

            if (UpThresholdEvent != null && _dal.ReadList().Count > 10)
                UpThresholdEvent(_dal.ReadList().Count);
        }
        public Boolean RemoveProduct(int productId)
        {
            var result = _dal.Remove(productId);

            var count = _dal.ReadList().Count;

            if (DownThresholdEvent != null && count < 5)
                DownThresholdEvent(_dal.ReadList().Count);

            return result;
        }
        public Boolean UpdateProduct(Product updateProduct)
        {
            return _dal.Update(updateProduct);
        }
        public Product ReadProduct(int productId)
        {
            return _dal.ReadOne(productId);
        }
        public List<Product> ReadProductList()
        {
            return _dal.ReadList();
        }

    }
}
