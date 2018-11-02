using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService
{
    public class PromotionDBContext : DbContext
    {
        public PromotionDBContext(DbContextOptions<PromotionDBContext> options)
            : base(options)
        {

        }
        //public DbSet<ProductInfo> ProductInfos { get; set; }
 
    }
}
