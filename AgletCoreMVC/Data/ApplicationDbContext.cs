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
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Lace> Lace { get; set; }


    }
}
