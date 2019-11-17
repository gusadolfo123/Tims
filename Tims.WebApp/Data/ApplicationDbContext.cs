using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tims.WebApp.Models;

namespace Tims.WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Billing> Billings { get; set; }
        public DbSet<ReceptionType> ReceptionTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
