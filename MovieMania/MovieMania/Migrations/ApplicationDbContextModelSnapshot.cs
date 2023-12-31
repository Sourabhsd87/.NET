﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieMania.Data;

#nullable disable

namespace MovieMania.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MovieMania.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("movieName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("producer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("releaseDate")
                        .HasColumnType("date");

                    b.Property<double>("ticket")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("movieName");

                    b.ToTable("Moviess");
                });
#pragma warning restore 612, 618
        }
    }
}
