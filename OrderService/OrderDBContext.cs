using Microsoft.EntityFrameworkCore;
using OrderService.Domain.Models;
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
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<OrderProductInfo> OrderProductInfos { get; set; }
        public DbSet<OrderActionInfo> OrderActionInfos { get; set; }
        public DbSet<OrderAfterServiceInfo> OrderAfterServiceInfos { get; set; }
        public DbSet<OrderRefundInfo> OrderRefundInfos { get; set; }


    }
}
