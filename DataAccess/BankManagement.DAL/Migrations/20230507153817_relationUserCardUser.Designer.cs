﻿// <auto-generated />
using System;
using BankManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BankManagement.DAL.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20230507153817_relationUserCardUser")]
    partial class relationUserCardUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BankManagement.DAL.Entities.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5713),
                            Name = "Kapital Bank "
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5728),
                            Name = "ABB"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5730),
                            Name = "Merkezi Bank"
                        });
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.CardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<decimal>("CashBack")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Comission")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaxCapacity")
                        .HasColumnType("decimal(12,2)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("CardTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BankId = 1,
                            CashBack = 0m,
                            Comission = 10m,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5971),
                            MaxCapacity = 10000m,
                            Name = "Bir Kart"
                        },
                        new
                        {
                            Id = 2,
                            BankId = 1,
                            CashBack = 5m,
                            Comission = 0m,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5974),
                            MaxCapacity = 5000m,
                            Name = "Premium Kart"
                        },
                        new
                        {
                            Id = 3,
                            BankId = 2,
                            CashBack = 0m,
                            Comission = 5m,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(5977),
                            MaxCapacity = 20000m,
                            Name = "Tam Kart"
                        },
                        new
                        {
                            Id = 4,
                            BankId = 2,
                            CashBack = 10m,
                            Comission = 0m,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(6075),
                            MaxCapacity = 10000m,
                            Name = "Gənc Kart"
                        },
                        new
                        {
                            Id = 5,
                            BankId = 3,
                            CashBack = 0m,
                            Comission = 5m,
                            CreatedAt = new DateTime(2023, 5, 7, 19, 38, 17, 583, DateTimeKind.Local).AddTicks(6078),
                            MaxCapacity = 100000m,
                            Name = "Mərkəz Kart"
                        });
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pin")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Pin")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.UserCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CVV")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasMaxLength(16)
                        .HasColumnType("int");

                    b.Property<int>("Pincode")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCards");
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.CardType", b =>
                {
                    b.HasOne("BankManagement.DAL.Entities.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.UserCard", b =>
                {
                    b.HasOne("BankManagement.DAL.Entities.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BankManagement.DAL.Entities.User", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
