using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //ISP
    internal interface IWriteRepository
    {
        void Create();
        void Remove();
        void Update();
    }
    internal interface IReadRepository
    {
        void GetAll2();
        void Get(int id);
    }

    internal class Repository2 : IReadRepository, IWriteRepository
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
