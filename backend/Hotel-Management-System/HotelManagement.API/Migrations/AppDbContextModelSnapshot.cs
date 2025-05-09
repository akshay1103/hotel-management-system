﻿// <auto-generated />
using System;
using HotelManagement.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin1@example.com",
                            FullName = "Admin User 1",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_1",
                            PhoneNumber = "1234567801",
                            Role = "SuperAdmin",
                            Username = "admin1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin2@example.com",
                            FullName = "Admin User 2",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_2",
                            PhoneNumber = "1234567802",
                            Role = "Manager",
                            Username = "admin2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin3@example.com",
                            FullName = "Admin User 3",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_3",
                            PhoneNumber = "1234567803",
                            Role = "SuperAdmin",
                            Username = "admin3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin4@example.com",
                            FullName = "Admin User 4",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_4",
                            PhoneNumber = "1234567804",
                            Role = "Manager",
                            Username = "admin4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin5@example.com",
                            FullName = "Admin User 5",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_5",
                            PhoneNumber = "1234567805",
                            Role = "SuperAdmin",
                            Username = "admin5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin6@example.com",
                            FullName = "Admin User 6",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_6",
                            PhoneNumber = "1234567806",
                            Role = "Manager",
                            Username = "admin6"
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin7@example.com",
                            FullName = "Admin User 7",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_7",
                            PhoneNumber = "1234567807",
                            Role = "SuperAdmin",
                            Username = "admin7"
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin8@example.com",
                            FullName = "Admin User 8",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_8",
                            PhoneNumber = "1234567808",
                            Role = "Manager",
                            Username = "admin8"
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin9@example.com",
                            FullName = "Admin User 9",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_9",
                            PhoneNumber = "1234567809",
                            Role = "SuperAdmin",
                            Username = "admin9"
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin10@example.com",
                            FullName = "Admin User 10",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_10",
                            PhoneNumber = "1234567810",
                            Role = "Manager",
                            Username = "admin10"
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin11@example.com",
                            FullName = "Admin User 11",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_11",
                            PhoneNumber = "1234567811",
                            Role = "SuperAdmin",
                            Username = "admin11"
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin12@example.com",
                            FullName = "Admin User 12",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_12",
                            PhoneNumber = "1234567812",
                            Role = "Manager",
                            Username = "admin12"
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin13@example.com",
                            FullName = "Admin User 13",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_13",
                            PhoneNumber = "1234567813",
                            Role = "SuperAdmin",
                            Username = "admin13"
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin14@example.com",
                            FullName = "Admin User 14",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_14",
                            PhoneNumber = "1234567814",
                            Role = "Manager",
                            Username = "admin14"
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin15@example.com",
                            FullName = "Admin User 15",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_15",
                            PhoneNumber = "1234567815",
                            Role = "SuperAdmin",
                            Username = "admin15"
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin16@example.com",
                            FullName = "Admin User 16",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_16",
                            PhoneNumber = "1234567816",
                            Role = "Manager",
                            Username = "admin16"
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin17@example.com",
                            FullName = "Admin User 17",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_17",
                            PhoneNumber = "1234567817",
                            Role = "SuperAdmin",
                            Username = "admin17"
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin18@example.com",
                            FullName = "Admin User 18",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_18",
                            PhoneNumber = "1234567818",
                            Role = "Manager",
                            Username = "admin18"
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin19@example.com",
                            FullName = "Admin User 19",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_19",
                            PhoneNumber = "1234567819",
                            Role = "SuperAdmin",
                            Username = "admin19"
                        },
                        new
                        {
                            Id = 20,
                            CreatedAt = new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin20@example.com",
                            FullName = "Admin User 20",
                            IsActive = true,
                            LastLoginAt = new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PasswordHash = "hashed_password_20",
                            PhoneNumber = "1234567820",
                            Role = "Manager",
                            Username = "admin20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
