using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using MtpApp.Entity;

namespace MtpApp.DataAccess
{
   public class MTPDataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        public MTPDataContext(DbContextOptions<MTPDataContext> opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        //    optionsBuilder.UseSqlServer(@"Data Source=27.254.174.191;Initial Catalog=admin_mtp;Persist Security Info=True;User ID=admin_mtp;Password=Sinetong9977");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
