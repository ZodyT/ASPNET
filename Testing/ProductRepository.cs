using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;
using Dapper;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        IEnumerable<Product> IProductRepository.GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * from PRODUCTS;");
        }
    }
}
