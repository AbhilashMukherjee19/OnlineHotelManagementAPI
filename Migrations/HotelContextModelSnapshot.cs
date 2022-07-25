﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineHotelManagementAPI.Models;

#nullable disable

namespace OnlineHotelManagementAPI.Migrations
{
    [DbContext(typeof(HotelContext))]
    partial class HotelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Admin", b =>
                {
                    b.Property<string>("AdminName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminName");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhnNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.HasKey("GuestId");

                    b.HasIndex("roomId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("InventoryName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Inventoriess");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"), 1L, 1);

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("CardholderName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PaymentID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Rate", b =>
                {
                    b.Property<int>("rate_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rate_id"), 1L, 1);

                    b.Property<double>("ExtensionPrice")
                        .HasColumnType("float");

                    b.Property<int>("No_of_Days")
                        .HasColumnType("int");

                    b.Property<double>("PerNightPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.HasKey("rate_id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PhnNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("advance_payment")
                        .HasColumnType("float");

                    b.Property<string>("checkout_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("chekin_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("guestId")
                        .HasColumnType("int");

                    b.Property<int>("no_of_adults")
                        .HasColumnType("int");

                    b.Property<int>("no_of_children")
                        .HasColumnType("int");

                    b.Property<string>("no_of_rooms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("guestId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Room", b =>
                {
                    b.Property<int>("room_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("room_id"), 1L, 1);

                    b.Property<DateTime>("check_in")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("check_out")
                        .HasColumnType("datetime2");

                    b.Property<int>("rateId")
                        .HasColumnType("int");

                    b.Property<string>("room_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("room_id");

                    b.HasIndex("rateId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("StaffName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Guest", b =>
                {
                    b.HasOne("OnlineHotelManagementAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("roomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Reservation", b =>
                {
                    b.HasOne("OnlineHotelManagementAPI.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("guestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");
                });

            modelBuilder.Entity("OnlineHotelManagementAPI.Models.Room", b =>
                {
                    b.HasOne("OnlineHotelManagementAPI.Models.Rate", "Rate")
                        .WithMany()
                        .HasForeignKey("rateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rate");
                });
#pragma warning restore 612, 618
        }
    }
}
