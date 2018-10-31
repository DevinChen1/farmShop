using framShop.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductServiceContext : DbContext
    {
        public ProductServiceContext(DbContextOptions<ProductServiceContext> options)
            : base(options)
        {
        }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<ProductImageInfo> ProductImageInfos { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }


    }
}
