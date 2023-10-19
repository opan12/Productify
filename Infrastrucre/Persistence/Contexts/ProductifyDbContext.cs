
using Microsoft.EntityFrameworkCore;
using Productify.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = System.Data.Entity.DbContext;

namespace Productify.Persistence.Contexts
{
    public class ProductifyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("ProductifyDb");
        }
    }
}
