using CartService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartService
{
    public class CartDBContext : DbContext
    {
        public CartDBContext(DbContextOptions<CartDBContext> options)
            : base(options)
        {

        }
        public DbSet<CartProductInfo> CartProductInfos { get; set; }
 
    }
}
