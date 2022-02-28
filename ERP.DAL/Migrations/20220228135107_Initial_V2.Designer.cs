﻿// <auto-generated />
using ERP.DAL.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP.DAL.Migrations
{
    [DbContext(typeof(ERPDbContext))]
    [Migration("20220228135107_Initial_V2")]
    partial class Initial_V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ERP.Entities.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidId"), 1L, 1);

                    b.Property<int>("BuyOrderOrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("BidId");

                    b.HasIndex("BuyOrderOrderId");

                    b.ToTable("Bid");
                });

            modelBuilder.Entity("ERP.Entities.Models.BuyOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("SupplyTermsContractId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("SupplyTermsContractId");

                    b.ToTable("BuyOrder");
                });

            modelBuilder.Entity("ERP.Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ERP.Entities.Models.SupplyTermsContract", b =>
                {
                    b.Property<int>("SupplyTermsContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyTermsContractId"), 1L, 1);

                    b.Property<bool>("IsSigned")
                        .HasColumnType("bit");

                    b.HasKey("SupplyTermsContractId");

                    b.ToTable("SupplyTermsContract");
                });

            modelBuilder.Entity("ERP.Entities.Models.Bid", b =>
                {
                    b.HasOne("ERP.Entities.Models.BuyOrder", "BuyOrder")
                        .WithMany("Bid")
                        .HasForeignKey("BuyOrderOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuyOrder");
                });

            modelBuilder.Entity("ERP.Entities.Models.BuyOrder", b =>
                {
                    b.HasOne("ERP.Entities.Models.SupplyTermsContract", "SupplyTermsContract")
                        .WithMany("BuyOrder")
                        .HasForeignKey("SupplyTermsContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SupplyTermsContract");
                });

            modelBuilder.Entity("ERP.Entities.Models.BuyOrder", b =>
                {
                    b.Navigation("Bid");
                });

            modelBuilder.Entity("ERP.Entities.Models.SupplyTermsContract", b =>
                {
                    b.Navigation("BuyOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
