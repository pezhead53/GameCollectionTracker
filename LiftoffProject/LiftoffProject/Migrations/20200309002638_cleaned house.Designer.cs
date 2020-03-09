﻿// <auto-generated />
using System;
using LiftoffProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LiftoffProject.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20200309002638_cleaned house")]
    partial class cleanedhouse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LiftoffProject.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AggregatedRating")
                        .HasColumnType("real");

                    b.Property<int>("AggregatedRatingCount")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<long>("Collection")
                        .HasColumnType("bigint");

                    b.Property<int>("Cover")
                        .HasColumnType("int");

                    b.Property<long>("CreatedAt")
                        .HasColumnType("bigint");

                    b.Property<long>("Franchise")
                        .HasColumnType("bigint");

                    b.Property<int?>("GameCoverid")
                        .HasColumnType("int");

                    b.Property<int>("Hypes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Popularity")
                        .HasColumnType("real");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<int>("RatingCount")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storyline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalRating")
                        .HasColumnType("real");

                    b.Property<int>("TotalRatingCount")
                        .HasColumnType("int");

                    b.Property<long>("UpdatedAt")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameCoverid");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LiftoffProject.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CreatedAt")
                        .HasColumnType("bigint");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UpdatedAt")
                        .HasColumnType("bigint");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("LiftoffProject.Models.GenreGameId", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GenreGameIds");
                });

            modelBuilder.Entity("LiftoffProject.Models.Image", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.Property<int>("game")
                        .HasColumnType("int");

                    b.Property<string>("image_id")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Screenshots");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Image");
                });

            modelBuilder.Entity("LiftoffProject.Models.ReleaseDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("CreatedAt")
                        .HasColumnType("int");

                    b.Property<int>("Date")
                        .HasColumnType("int");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Human")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Platform")
                        .HasColumnType("int");

                    b.Property<int>("Region")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedAt")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("ReleaseDate");
                });

            modelBuilder.Entity("LiftoffProject.Models.Cover", b =>
                {
                    b.HasBaseType("LiftoffProject.Models.Image");

                    b.HasDiscriminator().HasValue("Cover");
                });

            modelBuilder.Entity("LiftoffProject.Models.Game", b =>
                {
                    b.HasOne("LiftoffProject.Models.Cover", "GameCover")
                        .WithMany()
                        .HasForeignKey("GameCoverid");
                });

            modelBuilder.Entity("LiftoffProject.Models.Genre", b =>
                {
                    b.HasOne("LiftoffProject.Models.Game", null)
                        .WithMany("Genres")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("LiftoffProject.Models.GenreGameId", b =>
                {
                    b.HasOne("LiftoffProject.Models.Game", "Game")
                        .WithMany("GenreGameIds")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LiftoffProject.Models.Genre", "Genre")
                        .WithMany("GenreGameIds")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LiftoffProject.Models.ReleaseDate", b =>
                {
                    b.HasOne("LiftoffProject.Models.Game", null)
                        .WithMany("ReleaseDates")
                        .HasForeignKey("GameId");
                });
#pragma warning restore 612, 618
        }
    }
}
