﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepository
    {
        public List<Product> GetProductFeatures()
        {
            using (var c=new Context())
            {
                return c.Products.Include(x=>x.ProductFeatureList).ThenInclude(x=>x.Feature).Include(x=>x.ProductCategorList).ToList();
            }
        }
    }
}
