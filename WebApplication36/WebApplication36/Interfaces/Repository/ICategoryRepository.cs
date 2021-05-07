using MongoRepo.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Models;

namespace WebApplication36.Interfaces.Repository
{
    interface ICategoryRepository : ICommonRepository<Category>
    {
    }
}
