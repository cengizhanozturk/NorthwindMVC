using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class DemoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAMBORGHINI;Database=Northwind;Trusted_Connection=true; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
