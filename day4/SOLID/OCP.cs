using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4.SOLID
{
    //Object Closed Principle
    public interface IRepository
    {
        List<string> GetAll();
    }
    public class SqlRepository : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "SQL DATA 1","SQL DATA 2"}; 
        }
    }
    public class MongoDBRepository : IRepository
    {
        public List<string> GetAll()
        {
            return new List<string>() { "MONGODB DATA 1", "MONGODB DATA 2" };
        }
    }
    internal class ProductRepository2
    {
        private readonly IRepository repository;

        public ProductRepository2(IRepository repository)
        {
            this.repository = repository;
        }

        public List<string> GetAll()
        {
            return repository.GetAll();
        }
    }
}
