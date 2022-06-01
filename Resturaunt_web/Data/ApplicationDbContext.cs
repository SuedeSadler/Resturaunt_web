using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Resturaunt_web.Models;

namespace Resturaunt_web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Resturaunt_web.Models.Menu> Menu { get; set; }
        public DbSet<Resturaunt_web.Models.Reservations1> Reservations1 { get; set; }
        public DbSet<Resturaunt_web.Models.Registered_Customers> Registered_Customers { get; set; }
    }
}
