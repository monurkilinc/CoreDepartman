﻿// <auto-generated />
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230224163752_sutunkaldir")]
    partial class sutunkaldir
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreDepartman.Models.departmanlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("departmanad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("CoreDepartman.Models.personel", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("perid"));

                    b.Property<string>("ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perid");

                    b.ToTable("personels");
                });
#pragma warning restore 612, 618
        }
    }
}
