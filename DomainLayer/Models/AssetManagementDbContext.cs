using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace DomainLayer.Models
{
    

   
        public class AssetManagementDbContext : DbContext
        {
            public AssetManagementDbContext(DbContextOptions<AssetManagementDbContext> options)
                : base(options)
            {
            }

            // Tables
            public DbSet<Role> Roles { get; set; }

            public DbSet<User> Users { get; set; }

            public DbSet<AssetType> AssetTypes { get; set; }

            public DbSet<AssetDefinition> AssetDefinitions { get; set; }

            public DbSet<Vendor> Vendors { get; set; }

            public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

            public DbSet<Asset> Assets { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Seed Roles
                modelBuilder.Entity<Role>().HasData(
                    new Role
                    {
                        RoleId = 1,
                        RoleName = "Admin"
                    },
                    new Role
                    {
                        RoleId = 2,
                        RoleName = "User"
                    }
                );

                // Seed Asset Types
                modelBuilder.Entity<AssetType>().HasData(
                    new AssetType
                    {
                        AssetTypeId = 1,
                        AssetTypeName = "Laptop",
                        Description = "Laptop Devices",
                        IsActive = true
                    },
                    new AssetType
                    {
                        AssetTypeId = 2,
                        AssetTypeName = "Mobile",
                        Description = "Mobile Devices",
                        IsActive = true
                    },
                    new AssetType
                    {
                        AssetTypeId = 3,
                        AssetTypeName = "Printer",
                        Description = "Printer Devices",
                        IsActive = true
                    }
                );

            // Seed Vendors
            modelBuilder.Entity<Vendor>().HasData(
                new Vendor
                {
                    VendorId = 1,
                    VendorName = "Dell Technologies",
                    ContactPerson = "John Smith",
                    ContactNumber = "9876543210",
                    Email = "john@dell.com",
                    Address = "Bangalore",
                    IsActive = true
                },
                new Vendor
                {
                    VendorId = 2,
                    VendorName = "HP India",
                    ContactPerson = "Rahul Kumar",
                    ContactNumber = "9123456780",
                    Email = "rahul@hp.com",
                    Address = "Chennai",
                    IsActive = true
                }
              );




            // Seed Asset Definitions
            modelBuilder.Entity<AssetDefinition>().HasData(
                new AssetDefinition
                {
                    AssetDefinitionId = 1,
                    AssetName = "Dell Latitude 5420",
                    Brand = "Dell",
                    Model = "Latitude 5420",
                    AssetTypeId = 1,
                    Description = "Business Laptop",
                    IsActive = true
                },
                new AssetDefinition
                {
                    AssetDefinitionId = 2,
                    AssetName = "Samsung Galaxy S24",
                    Brand = "Samsung",
                    Model = "S24",
                    AssetTypeId = 2,
                    Description = "Android Mobile",
                    IsActive = true
                },
                new AssetDefinition
                {
                    AssetDefinitionId = 3,
                    AssetName = "HP LaserJet Pro",
                    Brand = "HP",
                    Model = "M404",
                    AssetTypeId = 3,
                    Description = "Office Printer",
                    IsActive = true
                }
            );


            // Seed Purchase Orders
            modelBuilder.Entity<PurchaseOrder>().HasData(
                new PurchaseOrder
                {
                    PurchaseOrderId = 1,
                    VendorId = 1,
                    AssetDefinitionId = 1,
                    Quantity = 10,
                    UnitPrice = 65000.00m,
                    PurchaseDate = new DateTime(2026, 6, 1),
                    Status = "Asset Details Registered Internally"
                },
                new PurchaseOrder
                {
                    PurchaseOrderId = 2,
                    VendorId = 2,
                    AssetDefinitionId = 2,
                    Quantity = 15,
                    UnitPrice = 45000.00m,
                    PurchaseDate = new DateTime(2026, 6, 5),
                    Status = "Asset Details Registered Internally"
                }
             );
















        }
        }
    

}
