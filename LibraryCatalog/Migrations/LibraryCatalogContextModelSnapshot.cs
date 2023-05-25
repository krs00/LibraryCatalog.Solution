﻿// <auto-generated />
using System;
using LibraryCatalog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryCatalog.Migrations
{
    [DbContext(typeof(LibraryCatalogContext))]
    partial class LibraryCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryCatalog.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.HasKey("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryCatalog.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Genre")
                        .HasColumnType("longtext");

                    b.Property<string>("Publisher")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryCatalog.Models.Author", b =>
                {
                    b.HasOne("LibraryCatalog.Models.Book", null)
                        .WithMany("Authors")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("LibraryCatalog.Models.Book", b =>
                {
                    b.HasOne("LibraryCatalog.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("LibraryCatalog.Models.Book", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
