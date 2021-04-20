﻿// <auto-generated />
using System;
using API_Basta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Basta.Migrations
{
    [DbContext(typeof(BasteContext))]
    [Migration("20210323170338_V2")]
    partial class V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_Basta.Models.Baste", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int")
                        .HasColumnName("Kapacitet");

                    b.Property<int>("M")
                        .HasColumnType("int")
                        .HasColumnName("M");

                    b.Property<int>("N")
                        .HasColumnType("int")
                        .HasColumnName("N");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Naziv");

                    b.Property<int?>("PoljoprivrednikID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PoljoprivrednikID");

                    b.ToTable("Baste");
                });

            modelBuilder.Entity("API_Basta.Models.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BastaID")
                        .HasColumnType("int");

                    b.Property<int>("Kapacitet")
                        .HasColumnType("int")
                        .HasColumnName("Kapacitet");

                    b.Property<int>("MaxKapacitet")
                        .HasColumnType("int")
                        .HasColumnName("MaxKapacitet");

                    b.Property<string>("Tip")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tip");

                    b.Property<string>("Vrsta")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Vrsta");

                    b.Property<int>("X")
                        .HasColumnType("int")
                        .HasColumnName("X");

                    b.Property<int>("Y")
                        .HasColumnType("int")
                        .HasColumnName("Y");

                    b.HasKey("ID");

                    b.HasIndex("BastaID");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("API_Basta.Models.Poljoprivrednik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Adresa");

                    b.Property<string>("Naziv")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Ime");

                    b.HasKey("ID");

                    b.ToTable("Poljoprivrednik");
                });

            modelBuilder.Entity("API_Basta.Models.Baste", b =>
                {
                    b.HasOne("API_Basta.Models.Poljoprivrednik", "Poljoprivrednik")
                        .WithMany("Baste")
                        .HasForeignKey("PoljoprivrednikID");

                    b.Navigation("Poljoprivrednik");
                });

            modelBuilder.Entity("API_Basta.Models.Lokacija", b =>
                {
                    b.HasOne("API_Basta.Models.Baste", "Basta")
                        .WithMany("Lokacije")
                        .HasForeignKey("BastaID");

                    b.Navigation("Basta");
                });

            modelBuilder.Entity("API_Basta.Models.Baste", b =>
                {
                    b.Navigation("Lokacije");
                });

            modelBuilder.Entity("API_Basta.Models.Poljoprivrednik", b =>
                {
                    b.Navigation("Baste");
                });
#pragma warning restore 612, 618
        }
    }
}
