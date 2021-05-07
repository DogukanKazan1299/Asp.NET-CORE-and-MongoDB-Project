using MongoRepo.Context;
using MongoRepo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Database;
using WebApplication36.Interfaces.Repository;
using WebApplication36.Models;

namespace WebApplication36.Repository
{
    public class ProductRepository : CommonRepository<Product> , IProductRepository
    {
        public ProductRepository() : base(new ApplicationDbContext(DbConnection.ConnectionString,DbConnection.DBName))
        {

        }
    }
}
