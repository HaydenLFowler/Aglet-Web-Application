using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgletCoreMVC.Models;

namespace AgletCoreMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AgletCoreMVC.Models.Address> Address { get; set; }
        public DbSet<AgletCoreMVC.Models.PaymentCard> PaymentCard { get; set; }
        public DbSet<AgletCoreMVC.Models.User> User { get; set; }
    }
}
