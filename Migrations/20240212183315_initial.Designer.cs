﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCryptoScanner.Data.DbConnection;

#nullable disable

namespace MyCryptoScanner.UI.Migrations
{
    [DbContext(typeof(CoinDbContext))]
    [Migration("20240212183315_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyCryptoScanner.Data.Models.CoinDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DescriptionId");

                    b.ToTable("Coins");
                });

            modelBuilder.Entity("MyCryptoScanner.Data.Models.Description", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Da")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("De")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("El")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("En")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Es")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("He")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("It")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Th")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZhTw")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Description");
                });

            modelBuilder.Entity("MyCryptoScanner.Data.Models.CoinDbModel", b =>
                {
                    b.HasOne("MyCryptoScanner.Data.Models.Description", "Description")
                        .WithMany()
                        .HasForeignKey("DescriptionId");

                    b.Navigation("Description");
                });
#pragma warning restore 612, 618
        }
    }
}
