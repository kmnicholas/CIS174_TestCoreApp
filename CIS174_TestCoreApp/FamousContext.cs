using CIS174_TestCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp
{
    public class FamousContext : DbContext
    {
        public FamousContext(DbContextOptions<FamousContext> options)
            : base(options) { }

        public DbSet<FamousPerson> FamousPeople { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"");
    }
}
