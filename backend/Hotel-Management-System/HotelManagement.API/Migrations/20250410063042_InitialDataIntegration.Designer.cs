﻿// <auto-generated />
using System;
using HotelManagement.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250410063042_InitialDataIntegration")]
    partial class InitialDataIntegration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelManagement.API.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9089),
                            Email = "admin1@example.com",
                            FullName = "Admin User 1",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 10, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9235),
                            PasswordHash = "hashed_password_1",
                            PhoneNumber = "1234567801",
                            Role = "SuperAdmin",
                            Username = "admin1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9519),
                            Email = "admin2@example.com",
                            FullName = "Admin User 2",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9519),
                            PasswordHash = "hashed_password_2",
                            PhoneNumber = "1234567802",
                            Role = "Manager",
                            Username = "admin2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9525),
                            Email = "admin3@example.com",
                            FullName = "Admin User 3",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 9, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9525),
                            PasswordHash = "hashed_password_3",
                            PhoneNumber = "1234567803",
                            Role = "SuperAdmin",
                            Username = "admin3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9529),
                            Email = "admin4@example.com",
                            FullName = "Admin User 4",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9529),
                            PasswordHash = "hashed_password_4",
                            PhoneNumber = "1234567804",
                            Role = "Manager",
                            Username = "admin4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9537),
                            Email = "admin5@example.com",
                            FullName = "Admin User 5",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 8, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9538),
                            PasswordHash = "hashed_password_5",
                            PhoneNumber = "1234567805",
                            Role = "SuperAdmin",
                            Username = "admin5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9548),
                            Email = "admin6@example.com",
                            FullName = "Admin User 6",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9548),
                            PasswordHash = "hashed_password_6",
                            PhoneNumber = "1234567806",
                            Role = "Manager",
                            Username = "admin6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9579),
                            Email = "admin7@example.com",
                            FullName = "Admin User 7",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 7, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9579),
                            PasswordHash = "hashed_password_7",
                            PhoneNumber = "1234567807",
                            Role = "SuperAdmin",
                            Username = "admin7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9585),
                            Email = "admin8@example.com",
                            FullName = "Admin User 8",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9585),
                            PasswordHash = "hashed_password_8",
                            PhoneNumber = "1234567808",
                            Role = "Manager",
                            Username = "admin8"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9588),
                            Email = "admin9@example.com",
                            FullName = "Admin User 9",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 6, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9588),
                            PasswordHash = "hashed_password_9",
                            PhoneNumber = "1234567809",
                            Role = "SuperAdmin",
                            Username = "admin9"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9595),
                            Email = "admin10@example.com",
                            FullName = "Admin User 10",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9595),
                            PasswordHash = "hashed_password_10",
                            PhoneNumber = "1234567810",
                            Role = "Manager",
                            Username = "admin10"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9598),
                            Email = "admin11@example.com",
                            FullName = "Admin User 11",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 5, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9598),
                            PasswordHash = "hashed_password_11",
                            PhoneNumber = "1234567811",
                            Role = "SuperAdmin",
                            Username = "admin11"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9601),
                            Email = "admin12@example.com",
                            FullName = "Admin User 12",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9601),
                            PasswordHash = "hashed_password_12",
                            PhoneNumber = "1234567812",
                            Role = "Manager",
                            Username = "admin12"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9604),
                            Email = "admin13@example.com",
                            FullName = "Admin User 13",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 4, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9604),
                            PasswordHash = "hashed_password_13",
                            PhoneNumber = "1234567813",
                            Role = "SuperAdmin",
                            Username = "admin13"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9607),
                            Email = "admin14@example.com",
                            FullName = "Admin User 14",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9607),
                            PasswordHash = "hashed_password_14",
                            PhoneNumber = "1234567814",
                            Role = "Manager",
                            Username = "admin14"
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2025, 3, 26, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9609),
                            Email = "admin15@example.com",
                            FullName = "Admin User 15",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 3, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9610),
                            PasswordHash = "hashed_password_15",
                            PhoneNumber = "1234567815",
                            Role = "SuperAdmin",
                            Username = "admin15"
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2025, 3, 25, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9613),
                            Email = "admin16@example.com",
                            FullName = "Admin User 16",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9614),
                            PasswordHash = "hashed_password_16",
                            PhoneNumber = "1234567816",
                            Role = "Manager",
                            Username = "admin16"
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2025, 3, 24, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9616),
                            Email = "admin17@example.com",
                            FullName = "Admin User 17",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 2, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9616),
                            PasswordHash = "hashed_password_17",
                            PhoneNumber = "1234567817",
                            Role = "SuperAdmin",
                            Username = "admin17"
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2025, 3, 23, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9620),
                            Email = "admin18@example.com",
                            FullName = "Admin User 18",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9620),
                            PasswordHash = "hashed_password_18",
                            PhoneNumber = "1234567818",
                            Role = "Manager",
                            Username = "admin18"
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2025, 3, 22, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9623),
                            Email = "admin19@example.com",
                            FullName = "Admin User 19",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 4, 1, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9623),
                            PasswordHash = "hashed_password_19",
                            PhoneNumber = "1234567819",
                            Role = "SuperAdmin",
                            Username = "admin19"
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2025, 3, 21, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9626),
                            Email = "admin20@example.com",
                            FullName = "Admin User 20",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9626),
                            PasswordHash = "hashed_password_20",
                            PhoneNumber = "1234567820",
                            Role = "Manager",
                            Username = "admin20"
                        },
                        new
                        {
                            Id = 21,
                            CreatedAt = new DateTime(2025, 3, 20, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9629),
                            Email = "admin21@example.com",
                            FullName = "Admin User 21",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 31, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9629),
                            PasswordHash = "hashed_password_21",
                            PhoneNumber = "1234567821",
                            Role = "SuperAdmin",
                            Username = "admin21"
                        },
                        new
                        {
                            Id = 22,
                            CreatedAt = new DateTime(2025, 3, 19, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9631),
                            Email = "admin22@example.com",
                            FullName = "Admin User 22",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9632),
                            PasswordHash = "hashed_password_22",
                            PhoneNumber = "1234567822",
                            Role = "Manager",
                            Username = "admin22"
                        },
                        new
                        {
                            Id = 23,
                            CreatedAt = new DateTime(2025, 3, 18, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9634),
                            Email = "admin23@example.com",
                            FullName = "Admin User 23",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 30, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9635),
                            PasswordHash = "hashed_password_23",
                            PhoneNumber = "1234567823",
                            Role = "SuperAdmin",
                            Username = "admin23"
                        },
                        new
                        {
                            Id = 24,
                            CreatedAt = new DateTime(2025, 3, 17, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9637),
                            Email = "admin24@example.com",
                            FullName = "Admin User 24",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9637),
                            PasswordHash = "hashed_password_24",
                            PhoneNumber = "1234567824",
                            Role = "Manager",
                            Username = "admin24"
                        },
                        new
                        {
                            Id = 25,
                            CreatedAt = new DateTime(2025, 3, 16, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9640),
                            Email = "admin25@example.com",
                            FullName = "Admin User 25",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 29, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9640),
                            PasswordHash = "hashed_password_25",
                            PhoneNumber = "1234567825",
                            Role = "SuperAdmin",
                            Username = "admin25"
                        },
                        new
                        {
                            Id = 26,
                            CreatedAt = new DateTime(2025, 3, 15, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9643),
                            Email = "admin26@example.com",
                            FullName = "Admin User 26",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9643),
                            PasswordHash = "hashed_password_26",
                            PhoneNumber = "1234567826",
                            Role = "Manager",
                            Username = "admin26"
                        },
                        new
                        {
                            Id = 27,
                            CreatedAt = new DateTime(2025, 3, 14, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9646),
                            Email = "admin27@example.com",
                            FullName = "Admin User 27",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 28, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9646),
                            PasswordHash = "hashed_password_27",
                            PhoneNumber = "1234567827",
                            Role = "SuperAdmin",
                            Username = "admin27"
                        },
                        new
                        {
                            Id = 28,
                            CreatedAt = new DateTime(2025, 3, 13, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9689),
                            Email = "admin28@example.com",
                            FullName = "Admin User 28",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9689),
                            PasswordHash = "hashed_password_28",
                            PhoneNumber = "1234567828",
                            Role = "Manager",
                            Username = "admin28"
                        },
                        new
                        {
                            Id = 29,
                            CreatedAt = new DateTime(2025, 3, 12, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9692),
                            Email = "admin29@example.com",
                            FullName = "Admin User 29",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 27, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9692),
                            PasswordHash = "hashed_password_29",
                            PhoneNumber = "1234567829",
                            Role = "SuperAdmin",
                            Username = "admin29"
                        },
                        new
                        {
                            Id = 30,
                            CreatedAt = new DateTime(2025, 3, 11, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9695),
                            Email = "admin30@example.com",
                            FullName = "Admin User 30",
                            IsActive = true,
                            LastLoginAt = new DateTime(2025, 3, 26, 6, 30, 42, 264, DateTimeKind.Utc).AddTicks(9695),
                            PasswordHash = "hashed_password_30",
                            PhoneNumber = "1234567830",
                            Role = "Manager",
                            Username = "admin30"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
