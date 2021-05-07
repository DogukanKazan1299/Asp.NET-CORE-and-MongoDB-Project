using MongoRepo.Interfaces.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Models;

namespace WebApplication36.Interfaces.Repository
{
    interface IProductRepository : ICommonManager<Product>
    {
    }
}
