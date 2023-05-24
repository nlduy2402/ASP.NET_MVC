﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext (DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Demo.Models.Category> Category { get; set; } = default!;

        public DbSet<Demo.Models.Product>? Product { get; set; }

        public DbSet<Demo.Models.User>? User { get; set; }
    }
}
