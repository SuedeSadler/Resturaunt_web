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
        internal object reservations1;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Resturaunt_web.Models.Menu> Menu { get; set; }
        public DbSet<Resturaunt_web.Models.Reservations1> Reservations1 { get; set; }
        public DbSet<Resturaunt_web.Models.Registered_Customers> Registered_Customers { get; set; }
        public DbSet<Resturaunt_web.Models.Login> Login { get; set; }
        public DbSet<Resturaunt_web.Models.SignUp> SignUp { get; set; }
    }
}
