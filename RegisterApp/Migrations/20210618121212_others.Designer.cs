﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegisterApp.DataAccess;

namespace RegisterApp.Migrations
{
    [DbContext(typeof(RegisterContext))]
    [Migration("20210618121212_others")]
    partial class others
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegisterApp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("RegisterId")
                        .HasColumnType("int");

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RegisterId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("RegisterApp.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RegisterId")
                        .HasColumnType("int");

                    b.Property<string>("countryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegisterId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("RegisterApp.Models.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RegisterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegisterId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("RegisterApp.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Register");
                });

            modelBuilder.Entity("RegisterApp.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("RegisterId")
                        .HasColumnType("int");

                    b.Property<string>("stateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("RegisterId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("RegisterApp.Models.Telephone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RegisterId")
                        .HasColumnType("int");

                    b.Property<string>("telNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RegisterId");

                    b.ToTable("Telephones");
                });

            modelBuilder.Entity("RegisterApp.Models.City", b =>
                {
                    b.HasOne("RegisterApp.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.HasOne("RegisterApp.Models.Register", null)
                        .WithMany("City")
                        .HasForeignKey("RegisterId");
                });

            modelBuilder.Entity("RegisterApp.Models.Country", b =>
                {
                    b.HasOne("RegisterApp.Models.Register", null)
                        .WithMany("Country")
                        .HasForeignKey("RegisterId");
                });

            modelBuilder.Entity("RegisterApp.Models.Email", b =>
                {
                    b.HasOne("RegisterApp.Models.Register", null)
                        .WithMany("EmailAdress")
                        .HasForeignKey("RegisterId");
                });

            modelBuilder.Entity("RegisterApp.Models.State", b =>
                {
                    b.HasOne("RegisterApp.Models.City", null)
                        .WithMany("States")
                        .HasForeignKey("CityId");

                    b.HasOne("RegisterApp.Models.Register", null)
                        .WithMany("States")
                        .HasForeignKey("RegisterId");
                });

            modelBuilder.Entity("RegisterApp.Models.Telephone", b =>
                {
                    b.HasOne("RegisterApp.Models.Register", null)
                        .WithMany("Telephone")
                        .HasForeignKey("RegisterId");
                });

            modelBuilder.Entity("RegisterApp.Models.City", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("RegisterApp.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("RegisterApp.Models.Register", b =>
                {
                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("EmailAdress");

                    b.Navigation("States");

                    b.Navigation("Telephone");
                });
#pragma warning restore 612, 618
        }
    }
}