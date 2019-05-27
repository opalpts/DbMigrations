using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DbMigrations.Model
{
    public class MainDBcontext : DbContext
    {
        public MainDBcontext(DbContextOptions<MainDBcontext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public object Product { get; internal set; }
    }
}
