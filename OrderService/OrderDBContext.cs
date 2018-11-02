using Microsoft.EntityFrameworkCore;
using ProductService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService
{
    public class OrderDBContext : DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options)
            : base(options)
        {

        }
        //public DbSet<ProductInfo> ProductInfos { get; set; }
 
    }
}
