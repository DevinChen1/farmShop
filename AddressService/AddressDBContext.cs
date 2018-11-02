using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService
{
    public class AddressDBContext : DbContext
    {
        public AddressDBContext(DbContextOptions<AddressDBContext> options)
            : base(options)
        {

        }
        //public DbSet<ProductInfo> ProductInfos { get; set; }
 
    }
}
