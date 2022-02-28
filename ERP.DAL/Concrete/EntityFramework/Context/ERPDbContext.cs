﻿using ERP.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DAL.Concrete.EntityFramework.Context
{
    public class ERPDbContext: DbContext
    {
        protected readonly IConfiguration _configuration;

        public ERPDbContext(IConfiguration configuration) { _configuration = configuration; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SqlConStr"));
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Bid> Bid { get; set; }
        public virtual DbSet<BuyOrder> BuyOrder { get; set; }
        public virtual DbSet<SupplyTermsContract> SupplyTermsContract { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey("ProductId");
            modelBuilder.Entity<Bid>().HasKey("BidId");
            modelBuilder.Entity<BuyOrder>().HasKey("OrderId");
            modelBuilder.Entity<SupplyTermsContract>().HasKey("SupplyTermsContractId");
        }

    }
}