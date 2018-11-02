using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService
{
    public class PaymentDBContext : DbContext
    {
        public PaymentDBContext(DbContextOptions<PaymentDBContext> options)
            : base(options)
        {

        }
        //public DbSet<ProductInfo> ProductInfos { get; set; }
 
    }
}
