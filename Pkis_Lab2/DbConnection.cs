using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pkis_lab2
{
    internal class DbConnection :DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Company> Company { get; set; } = null!;
        public DbSet<Goods> Goods { get; set; } = null!;
        public DbSet<Person> Person { get; set; } = null!;
        }
}
