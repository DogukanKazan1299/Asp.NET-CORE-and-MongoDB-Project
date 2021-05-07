using MongoRepo.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication36.Interfaces.Manager;
using WebApplication36.Models;
using WebApplication36.Repository;

namespace WebApplication36.Manager
{
    public class CategoryManager : CommonManager<Category>, ICategoryManager
    {
        public CategoryManager() : base(new CategoryRepository())
        {


        }
    }
}
