using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Domain.Models;

namespace AdminService
{
    public class AdminDBContext : DbContext
    {
        public AdminDBContext(DbContextOptions<AdminDBContext> options)
            : base(options)
        {

        }
        public DbSet<ActionInfo> ActionInfo { get; set; }
        public DbSet<AdminGroupInfo> AdminGroupInfos { get; set; }
 
    }
}
