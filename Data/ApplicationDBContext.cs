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
    }
}