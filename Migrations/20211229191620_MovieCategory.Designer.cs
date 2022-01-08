﻿// <auto-generated />
using System;
using Cinema.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20211229191620_MovieCategory")]
    partial class MovieCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cinema.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Cinema.Models.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirectorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DirectorID");

                    b.ToTable("Director");
                });

            modelBuilder.Entity("Cinema.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("MovieID");

                    b.HasIndex("DirectorID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Cinema.Models.MovieCategory", b =>
                {
                    b.Property<int>("MovieCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.HasKey("MovieCategoryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("MovieID");

                    b.ToTable("MovieCategory");
                });

            modelBuilder.Entity("Cinema.Models.Movie", b =>
                {
                    b.HasOne("Cinema.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("Cinema.Models.MovieCategory", b =>
                {
                    b.HasOne("Cinema.Models.Category", "Category")
                        .WithMany("MovieCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cinema.Models.Movie", "Movie")
                        .WithMany("MovieCategories")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Cinema.Models.Category", b =>
                {
                    b.Navigation("MovieCategories");
                });

            modelBuilder.Entity("Cinema.Models.Director", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Cinema.Models.Movie", b =>
                {
                    b.Navigation("MovieCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
