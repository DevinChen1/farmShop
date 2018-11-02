﻿using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {

        }
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<ProductImageInfo> ProductImageInfos { get; set; }
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
        public DbSet<CateProduct> CateProducts { get; set; }
    }
}