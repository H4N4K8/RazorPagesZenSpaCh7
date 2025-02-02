﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPages.Models;

#nullable disable

namespace RazorPagesZenSpaCh7.Migrations
{
    [DbContext(typeof(SpaContext))]
    partial class SpaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ServicesID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactEmail = "wilma@flint.net",
                            Name = "Wilma Flintstone",
                            ServicesID = 1
                        },
                        new
                        {
                            ID = 2,
                            ContactEmail = "Barn@rubb.com",
                            Name = "Barney Rubble",
                            ServicesID = 7
                        },
                        new
                        {
                            ID = 3,
                            ContactEmail = "betts@rubb.com",
                            Name = "Betty Rubble",
                            ServicesID = 5
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Services", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Classification = "Full",
                            Fee = 450.0,
                            Name = "Full-Day Treatment Package"
                        },
                        new
                        {
                            ID = 2,
                            Classification = "Half",
                            Fee = 300.0,
                            Name = "Half-Day Treatment Package"
                        },
                        new
                        {
                            ID = 3,
                            Classification = "Two",
                            Fee = 225.0,
                            Name = "Two-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 4,
                            Classification = "One",
                            Fee = 100.0,
                            Name = "One-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 5,
                            Classification = "Other",
                            Fee = 200.0,
                            Name = "Custom Treatment Package"
                        },
                        new
                        {
                            ID = 6,
                            Classification = "Cut",
                            Fee = 45.0,
                            Name = "Haircut or Trim"
                        },
                        new
                        {
                            ID = 7,
                            Classification = "Color",
                            Fee = 100.0,
                            Name = "Full Foil Color"
                        });
                });

            modelBuilder.Entity("RazorPagesZenSpaCh7.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("First Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Last Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Zipcode");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "flo@schmoe.net",
                            FirstName = "Flo",
                            LastName = "Schmoe",
                            Password = "FloSchmoe1234*",
                            Phone = "",
                            PostalCode = "",
                            State = "",
                            Username = "Flo"
                        },
                        new
                        {
                            ID = 2,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "jojo@schmoe.net",
                            FirstName = "Jo",
                            LastName = "Schmoe",
                            Password = "JoJoSchmoe1234?",
                            Phone = "",
                            PostalCode = "",
                            State = "",
                            Username = "JoJo"
                        },
                        new
                        {
                            ID = 3,
                            Address = "",
                            City = "",
                            ConfirmPassword = "",
                            Country = "",
                            Email = "truly@schmoe.net",
                            FirstName = "Truly",
                            LastName = "Schmoe",
                            Password = "Truly9876**",
                            Phone = "",
                            PostalCode = "",
                            State = "",
                            Username = "Truly"
                        });
                });

            modelBuilder.Entity("RazorPagesZenSpaCh7.Models.ClientService", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ServicesID");

                    b.ToTable("ClientServices");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClientID = 1,
                            Date = new DateTime(2024, 10, 27, 23, 15, 57, 456, DateTimeKind.Local).AddTicks(4090),
                            ServicesID = 1
                        },
                        new
                        {
                            ID = 2,
                            ClientID = 2,
                            Date = new DateTime(2024, 10, 27, 23, 15, 57, 456, DateTimeKind.Local).AddTicks(4148),
                            ServicesID = 7
                        },
                        new
                        {
                            ID = 3,
                            ClientID = 1,
                            Date = new DateTime(2024, 10, 27, 23, 15, 57, 456, DateTimeKind.Local).AddTicks(4149),
                            ServicesID = 5
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.HasOne("RazorPages.Models.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Services");
                });

            modelBuilder.Entity("RazorPagesZenSpaCh7.Models.ClientService", b =>
                {
                    b.HasOne("RazorPagesZenSpaCh7.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPages.Models.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
