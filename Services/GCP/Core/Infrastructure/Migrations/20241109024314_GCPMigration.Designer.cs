﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20241109024314_GCPMigration")]
    partial class GCPMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.GoodsReceipt", b =>
                {
                    b.Property<long>("GoodsReceiptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("GoodsReceiptID"));

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PurchaseOrderID")
                        .HasColumnType("bigint");

                    b.Property<int>("PurchaseOrderID1")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiptDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ReceivedBy")
                        .HasColumnType("bigint");

                    b.HasKey("GoodsReceiptID");

                    b.HasIndex("PurchaseOrderID1");

                    b.ToTable("GoodsReceipts");
                });

            modelBuilder.Entity("Domain.Entities.GoodsReceiptDetail", b =>
                {
                    b.Property<long>("GoodsReceiptDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("GoodsReceiptDetailID"));

                    b.Property<long>("GoodsReceiptID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceivedQuantity")
                        .HasColumnType("int");

                    b.Property<string>("WarehouseLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodsReceiptDetailID");

                    b.HasIndex("GoodsReceiptID");

                    b.ToTable("GoodsReceiptDetails");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseOrder", b =>
                {
                    b.Property<int>("PurchaseOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseOrderID"));

                    b.Property<DateTime?>("ActualDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("EstimatedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentTerms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("PurchaseOrderID");

                    b.ToTable("PurchaseOrders");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseOrderDetail", b =>
                {
                    b.Property<long>("PurchaseOrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PurchaseOrderDetailID"));

                    b.Property<string>("DestinationWarehouse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("PurchaseOrderID")
                        .HasColumnType("bigint");

                    b.Property<int>("PurchaseOrderID1")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PurchaseOrderDetailID");

                    b.HasIndex("PurchaseOrderID1");

                    b.ToTable("PurchaseOrderDetails");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseRequest", b =>
                {
                    b.Property<long>("PurchaseRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PurchaseRequestID"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RequestedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseRequestID");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseRequestDetail", b =>
                {
                    b.Property<long>("PurchaseRequestDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PurchaseRequestDetailID"));

                    b.Property<DateTime?>("NeededByDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long>("PurchaseRequestID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PurchaseRequestDetailID");

                    b.HasIndex("PurchaseRequestID");

                    b.ToTable("PurchaseRequestDetails");
                });

            modelBuilder.Entity("Domain.Entities.SupplierPayment", b =>
                {
                    b.Property<long>("SupplierPaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SupplierPaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PurchaseOrderID")
                        .HasColumnType("bigint");

                    b.Property<int>("PurchaseOrderID1")
                        .HasColumnType("int");

                    b.HasKey("SupplierPaymentID");

                    b.HasIndex("PurchaseOrderID1");

                    b.ToTable("SupplierPayment");
                });

            modelBuilder.Entity("Domain.Entities.GoodsReceipt", b =>
                {
                    b.HasOne("Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Domain.Entities.GoodsReceiptDetail", b =>
                {
                    b.HasOne("Domain.Entities.GoodsReceipt", "GoodsReceipt")
                        .WithMany()
                        .HasForeignKey("GoodsReceiptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GoodsReceipt");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseOrderDetail", b =>
                {
                    b.HasOne("Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });

            modelBuilder.Entity("Domain.Entities.PurchaseRequestDetail", b =>
                {
                    b.HasOne("Domain.Entities.PurchaseRequest", "PurchaseRequest")
                        .WithMany()
                        .HasForeignKey("PurchaseRequestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseRequest");
                });

            modelBuilder.Entity("Domain.Entities.SupplierPayment", b =>
                {
                    b.HasOne("Domain.Entities.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PurchaseOrder");
                });
#pragma warning restore 612, 618
        }
    }
}