using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<CustomerDetail> CustomerDetail { get; set; }
        public DbSet<VendorDetail> VendorDetail { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<VendorIdentityProof> VendorIdentityProof { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Orders> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .Property(o => o.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Orders>()
                .Property(ps => ps.PaymentStatus)
                .HasConversion<string>();
        }
    }
}