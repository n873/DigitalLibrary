﻿// <auto-generated />
using DigitalLibrary.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DigitalLibrary.Web.Migrations
{
    [DbContext(typeof(DigitalLibraryContext))]
    [Migration("20180809063444_AddDigitalBooksTable")]
    partial class AddDigitalBooksTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("DigitalLibrary.Web.Models.AudioBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<Guid?>("NaratorId");

                    b.Property<Guid?>("PublisherId");

                    b.Property<string>("Subtitle");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("NaratorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("AudioBook");
                });

            modelBuilder.Entity("DigitalLibrary.Web.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsNarator");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("DigitalLibrary.Web.Models.DigitalBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<Guid?>("PublisherId");

                    b.Property<string>("Subtitle");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("DigitalBooks");
                });

            modelBuilder.Entity("DigitalLibrary.Web.Models.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("DigitalLibrary.Web.Models.AudioBook", b =>
                {
                    b.HasOne("DigitalLibrary.Web.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DigitalLibrary.Web.Models.Author", "Narator")
                        .WithMany()
                        .HasForeignKey("NaratorId");

                    b.HasOne("DigitalLibrary.Web.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("DigitalLibrary.Web.Models.DigitalBook", b =>
                {
                    b.HasOne("DigitalLibrary.Web.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("DigitalLibrary.Web.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId");
                });
#pragma warning restore 612, 618
        }
    }
}
