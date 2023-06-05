﻿// <auto-generated />
using System;
using BenchmarkDemo.EfcoreDataAcess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BenchmarkDemo.Migrations
{
    [DbContext(typeof(UserBmDbContext))]
    partial class UserBmDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BenchmarkDemo.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AllowSetNewPassword")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FalseDeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFalseDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PasswordHash")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PasswordRecoveryPin")
                        .HasColumnType("int");

                    b.Property<Guid>("PasswordSalt")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RecoveryPinCreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BenchmarkDemo.Models.UserMaxProp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AllowSetNewPassword")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FalseDeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFalseDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("PasswordHash")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PasswordRecoveryPin")
                        .HasColumnType("int");

                    b.Property<Guid>("PasswordSalt")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RecoveryPinCreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserMaxProp");
                });
#pragma warning restore 612, 618
        }
    }
}
