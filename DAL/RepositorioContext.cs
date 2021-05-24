using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class RepositorioContext : DbContext
    {
        public RepositorioContext(): base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=WINAPVUUCDEC8EK\SQLEXPRESS;Initial Catalog=duasCamadas;Integrated Security=True");
        }
        public DbSet<Laptop> Laptops { get; set; }
    }
}
