using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDDBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace DDDBackend.Services.Context
{
    public class DataContext : DbContext 
    {
        public DbSet<RestaurantModel>? RestaurantInfo { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}