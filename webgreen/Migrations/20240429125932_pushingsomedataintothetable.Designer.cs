﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webgreen.data;

#nullable disable

namespace webgreen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429125932_pushingsomedataintothetable")]
    partial class pushingsomedataintothetable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webgreen.Models.cats", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("displayorder")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            displayorder = 1,
                            name = "comedy"
                        },
                        new
                        {
                            id = 2,
                            displayorder = 2,
                            name = "romance"
                        },
                        new
                        {
                            id = 3,
                            displayorder = 3,
                            name = "romcom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
