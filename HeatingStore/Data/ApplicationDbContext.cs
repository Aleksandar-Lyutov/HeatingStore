using HeatingStore.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HeatingStore.Models.HeatingDevice;
using HeatingStore.Models.Order;
using HeatingStore.Models.Client;
using HeatingStore.Models.Contact;

namespace HeatingStore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<HeatingDevice> HeatingDevices { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<HeatingStore.Models.HeatingDevice.HeatingDeviceCreateVM> HeatingDeviceCreateVM { get; set; }
        public DbSet<HeatingStore.Models.HeatingDevice.HeatingDeviceIndexVM> HeatingDeviceIndexVM { get; set; }
        public DbSet<HeatingStore.Models.HeatingDevice.HeatingDeviceEditVM> HeatingDeviceEditVM { get; set; }
        public DbSet<HeatingStore.Models.HeatingDevice.HeatingDeviceDetailsVM> HeatingDeviceDetailsVM { get; set; }
        public DbSet<HeatingStore.Models.HeatingDevice.HeatingDeviceDeleteVM> HeatingDeviceDeleteVM { get; set; }
        public DbSet<HeatingStore.Models.Order.OrderIndexVM> OrderIndexVM { get; set; }
        public DbSet<HeatingStore.Models.Order.OrderConfirmVM> OrderConfirmVM { get; set; }
        public DbSet<HeatingStore.Models.Client.ClientDeleteVM> ClientDeleteVM { get; set; }
        public DbSet<ContactMessageVM> ContactMessages { get; set; }
    }
}
