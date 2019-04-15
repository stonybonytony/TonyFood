using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TonyFood.Core;

namespace TonyFood.Data
{
    public class TonyFoodDbContext : DbContext
    {
        public TonyFoodDbContext(DbContextOptions<TonyFoodDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
