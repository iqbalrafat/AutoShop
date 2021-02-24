using AutoShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.AppDbContext
{
    public class AutoDbContext:DbContext
    {
        public AutoDbContext(DbContextOptions<AutoDbContext> options)
            :base(options)
        {
      
        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }


    }
}
