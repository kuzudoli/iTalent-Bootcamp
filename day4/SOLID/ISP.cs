using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //ISP
    internal interface IRepository2
    {
        void GetAll2();
        void Get(int id);
        void Create();
        void Remove();
        void Update();
    }

    internal class Repository2 : IRepository2
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAll2()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
