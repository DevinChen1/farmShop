using CategoryService.Domain.Models;
using Microsoft.EntityFrameworkCore;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace CategoryService
{
    public class CategoryDBContext : DbContext
    {
        public CategoryDBContext(DbContextOptions<CategoryDBContext> options)
            : base(options)
        {

        }
        
        public DbSet<CategoryInfo> CategoryInfos { get; set; }
 
    }
}
