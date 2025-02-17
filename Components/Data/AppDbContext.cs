﻿using BanSach.Components.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;
using System.Collections;
using System.Data;
namespace BanSach.Components.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Feature_Products> FeatureProducts { get; set; }
        public DbSet<Img> Imgs { get; set; }
        public DbSet<Personal_access_token> Personal_access_tokens { get; set; }
        public DbSet<Product_bill> Product_bills { get; set; }
        public DbSet<Product_cart> Product_carts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sell> Sells { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasKey(u => u.AddressId);
            modelBuilder.Entity<Address>()
                .Property(u => u.AddressId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Bill>()
                .HasKey(o => o.BillId);
            modelBuilder.Entity<Bill>()
                .Property(o => o.BillId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>()
                .HasKey(o => o.CategoryId);
            modelBuilder.Entity<Category>()
                .Property(o => o.CategoryId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Delivery>()
                .HasKey(m => m.DeliveryId);
            modelBuilder.Entity<Delivery>()
                .Property(m => m.DeliveryId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Feature_Products>()
                .HasKey(m => m.FeaturePId);
            modelBuilder.Entity<Feature_Products>()
                .Property(m => m.FeaturePId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Img>()
                .HasKey(m => m.ImgId);
            modelBuilder.Entity<Img>()
                .Property(m => m.ImgId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Personal_access_token>()
                .HasKey(m => m.PersonalId);
            modelBuilder.Entity<Personal_access_token>()
                .Property(m => m.PersonalId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product_bill>()
                .HasKey(m => m.ProductBillId);
            modelBuilder.Entity<Product_bill>()
                .Property(m => m.ProductBillId)
              .ValueGeneratedOnAdd();
           // modelBuilder.Entity<Bill>()
           //.HasOne(b => b.User)
           //.WithMany(u => u.Bills)
           //.HasForeignKey(b => b.UserId)
           //.OnDelete(DeleteBehavior.Cascade);  // Tùy chọn: xác định hành vi khi xóa

           // modelBuilder.Entity<Bill>()
           //     .HasOne(b => b.Address)
           //     .WithMany(a => a.Bills)
           //     .HasForeignKey(b => b.AddressId)
           //     .OnDelete(DeleteBehavior.Restrict);  // Ví dụ: Cấm xóa khi có hóa đơn liên quan

           // modelBuilder.Entity<Bill>()
           //     .HasOne(b => b.Delivery)
           //     .WithMany(d => d.Bills)
           //     .HasForeignKey(b => b.DeliveryId)
           //     .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Product_cart>()
                .HasKey(m => m.CartId);
            modelBuilder.Entity<Product_cart>()
                .Property(m => m.CartId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .HasKey(m => m.ProductId);
            modelBuilder.Entity<Product>()
                .Property(m => m.ProductId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Role>()
                .HasKey(m => m.RoleId);
            modelBuilder.Entity<Role>()
                .Property(m => m.RoleId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Sell>()
                .HasKey(m => m.SellId);
            modelBuilder.Entity<Sell>()
                .Property(m => m.SellId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .HasKey(m => m.UserId);
            modelBuilder.Entity<User>()
                .Property(m => m.UserId)
                .ValueGeneratedOnAdd();

    }
}
}

