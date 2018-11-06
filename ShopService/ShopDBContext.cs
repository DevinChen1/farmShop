using Microsoft.EntityFrameworkCore;
using ShopService.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopService
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext(DbContextOptions<ShopDBContext> options)
            : base(options)
        {

        }
        public DbSet<ShopInfo> ShopInfos { get; set; }
 
    }
}
