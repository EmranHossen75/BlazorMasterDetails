﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using work_001.Server.Models;

#nullable disable

namespace work_001.Server.Migrations
{
    [DbContext(typeof(TourDbContext))]
    partial class TourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("work_001.Shared.BookingEntry", b =>
                {
                    b.Property<int>("BookingEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingEntryId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("SpotId")
                        .HasColumnType("int");

                    b.HasKey("BookingEntryId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SpotId");

                    b.ToTable("BookingEntries");
                });

            modelBuilder.Entity("work_001.Shared.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("work_001.Shared.Spot", b =>
                {
                    b.Property<int>("SpotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpotId"), 1L, 1);

                    b.Property<string>("SpotName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpotId");

                    b.ToTable("Spots");

                    b.HasData(
                        new
                        {
                            SpotId = 1,
                            SpotName = "Coxs Bazar"
                        },
                        new
                        {
                            SpotId = 2,
                            SpotName = "Bandarban"
                        },
                        new
                        {
                            SpotId = 3,
                            SpotName = "Darjeling"
                        },
                        new
                        {
                            SpotId = 4,
                            SpotName = "Shilong"
                        },
                        new
                        {
                            SpotId = 5,
                            SpotName = "Meghaloy"
                        });
                });

            modelBuilder.Entity("work_001.Shared.BookingEntry", b =>
                {
                    b.HasOne("work_001.Shared.Customer", "Customer")
                        .WithMany("BookingEntries")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("work_001.Shared.Spot", "Spot")
                        .WithMany("BookingEntries")
                        .HasForeignKey("SpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Spot");
                });

            modelBuilder.Entity("work_001.Shared.Customer", b =>
                {
                    b.Navigation("BookingEntries");
                });

            modelBuilder.Entity("work_001.Shared.Spot", b =>
                {
                    b.Navigation("BookingEntries");
                });
#pragma warning restore 612, 618
        }
    }
}