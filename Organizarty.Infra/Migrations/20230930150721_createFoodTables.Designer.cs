﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Organizarty.Infra.Data.Contexts;

#nullable disable

namespace Organizarty.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230930150721_createFoodTables")]
    partial class createFoodTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("FoodInfoId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Note")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<Guid?>("PartyTemplateId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodInfoId");

                    b.HasIndex("PartyTemplateId");

                    b.ToTable("FoodGroup");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Flavour")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar(35)");

                    b.Property<Guid>("FoodTypeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ImagesJson")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("FoodInfo");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("varchar(35)");

                    b.Property<Guid>("ThirdPartyId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ThirdPartyId");

                    b.ToTable("FoodType");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<double?>("AreaSize")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("ImagesJson")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("RentPerDay")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.PartyTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("ExpectedGuests")
                        .HasColumnType("int");

                    b.Property<Guid?>("LocationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("UserId");

                    b.ToTable("PartyTemplate");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.ThirdParty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("LoginEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfissionalPhone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TagJSON")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ThirdParty");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("RolesJson")
                        .HasColumnType("longtext");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.UserConfirmEmail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ValidFor")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserConfirmEmails");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodGroup", b =>
                {
                    b.HasOne("Organizarty.Domain.Entities.FoodInfo", "FoodInfo")
                        .WithMany()
                        .HasForeignKey("FoodInfoId");

                    b.HasOne("Organizarty.Domain.Entities.PartyTemplate", "PartyTemplate")
                        .WithMany()
                        .HasForeignKey("PartyTemplateId");

                    b.Navigation("FoodInfo");

                    b.Navigation("PartyTemplate");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodInfo", b =>
                {
                    b.HasOne("Organizarty.Domain.Entities.FoodType", "FoodType")
                        .WithMany("Foods")
                        .HasForeignKey("FoodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodType");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodType", b =>
                {
                    b.HasOne("Organizarty.Domain.Entities.ThirdParty", "ThirdParty")
                        .WithMany()
                        .HasForeignKey("ThirdPartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThirdParty");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.PartyTemplate", b =>
                {
                    b.HasOne("Organizarty.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("Organizarty.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.UserConfirmEmail", b =>
                {
                    b.HasOne("Organizarty.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Organizarty.Domain.Entities.FoodType", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
