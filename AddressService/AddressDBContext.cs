﻿using AddressService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressService
{
    public class AddressDBContext : DbContext
    {
        public AddressDBContext(DbContextOptions<AddressDBContext> options)
            : base(options)
        {

        }
        public DbSet<RegionInfo> RegionInfos { get; set; }
        public DbSet<ShipAddressInfo> ShipAddressInfos { get; set; }

        

    }
}
