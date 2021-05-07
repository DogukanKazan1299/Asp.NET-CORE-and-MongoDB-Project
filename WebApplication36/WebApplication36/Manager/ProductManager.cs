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
    public class ProductManager : CommonManager<Product> , IProductManager
    {


        public ProductManager() : base(new ProductRepository())
        {

        }

        public bool IsExist(string name)
        {
            var product = GetFirstOrDefault(c => c.ItemName.ToLower() == name.ToLower());
            if(product != null)
            {
                return true;
            }
            return false;
        }
    }
}
