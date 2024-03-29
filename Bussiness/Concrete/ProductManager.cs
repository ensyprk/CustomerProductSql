﻿using Bussiness.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal) {
        
        _productDal = productDal;
        
        }
           public List<Product> GetAll()
        {
            // Bussines Codes

            return _productDal.GetAll();             
        }
    }
}
