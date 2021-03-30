using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RosePurchaseManagementCodeFirstFromDB
{
    public partial class RosePurchaseManagementEntities : DbContext
    {
        public RosePurchaseManagementEntities()
            : base("name=DatabaseConnection")
        {
        }

        public virtual DbSet<Box> Boxes { get; set; }
        public virtual DbSet<BoxInventory> BoxInventories { get; set; }
        public virtual DbSet<BoxPurchase> BoxPurchases { get; set; }
        public virtual DbSet<Farm> Farms { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
        public virtual DbSet<Rose> Roses { get; set; }
        public virtual DbSet<RoseSize> RoseSizes { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Box>()
                .HasMany(e => e.BoxInventories)
                .WithRequired(e => e.Box)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Box>()
                .HasMany(e => e.BoxPurchases)
                .WithRequired(e => e.Box)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Farm>()
                .HasMany(e => e.Inventories)
                .WithRequired(e => e.Farm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Farm>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Farm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Farm>()
                .HasMany(e => e.Purchases)
                .WithRequired(e => e.Farm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Roses)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.Price_per_stem);

            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.BoxInventories)
                .WithRequired(e => e.Inventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Purchase>()
                .Property(e => e.Price_per_stem);

            modelBuilder.Entity<Purchase>()
                .HasMany(e => e.BoxPurchases)
                .WithRequired(e => e.Purchase)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rose>()
                .HasMany(e => e.RoseSizes)
                .WithRequired(e => e.Rose)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoseSize>()
                .HasMany(e => e.Inventories)
                .WithRequired(e => e.RoseSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoseSize>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.RoseSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoseSize>()
                .HasMany(e => e.Purchases)
                .WithRequired(e => e.RoseSize)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.RoseSizes)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);
        }
    }
}
