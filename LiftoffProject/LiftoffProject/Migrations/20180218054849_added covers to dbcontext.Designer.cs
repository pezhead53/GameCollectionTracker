﻿// <auto-generated />
using LiftoffProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LiftoffProject.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20180218054849_added covers to dbcontext")]
    partial class addedcoverstodbcontext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LiftoffProject.Models.Cover", b =>
                {
                    b.Property<int>("CoverId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CloudinaryId");

                    b.Property<string>("Height");

                    b.Property<string>("Url");

                    b.Property<int>("Width");

                    b.HasKey("CoverId");

                    b.ToTable("Covers");
                });

            modelBuilder.Entity("LiftoffProject.Models.Game", b =>
                {
                    b.Property<int>("LocalId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AggregatedRating");

                    b.Property<int>("AggregatedRatingCount");

                    b.Property<int>("Category");

                    b.Property<long>("Collection");

                    b.Property<int>("CoverId");

                    b.Property<long>("CreatedAt");

                    b.Property<long>("FirstReleaseDate");

                    b.Property<long>("Franchise");

                    b.Property<int>("Hypes");

                    b.Property<int>("Id");

                    b.Property<string>("Name");

                    b.Property<float>("Popularity");

                    b.Property<int>("PulseCount");

                    b.Property<float>("Rating");

                    b.Property<int>("RatingCount");

                    b.Property<string>("Slug");

                    b.Property<int>("Status");

                    b.Property<string>("Storyline");

                    b.Property<string>("Summary");

                    b.Property<float>("TotalRating");

                    b.Property<int>("TotalRatingCount");

                    b.Property<long>("UpdatedAt");

                    b.Property<string>("Url");

                    b.HasKey("LocalId");

                    b.HasIndex("CoverId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LiftoffProject.Models.Rating", b =>
                {
                    b.Property<int>("LocalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RatingInt");

                    b.Property<string>("Synopsis");

                    b.HasKey("LocalId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("LiftoffProject.Models.TimeToBeat", b =>
                {
                    b.Property<int>("LocalId");

                    b.Property<int>("Completely");

                    b.Property<int>("Hastly");

                    b.Property<int>("Normally");

                    b.HasKey("LocalId");

                    b.ToTable("TimeToBeat");
                });

            modelBuilder.Entity("LiftoffProject.Models.Game", b =>
                {
                    b.HasOne("LiftoffProject.Models.Cover", "Cover")
                        .WithMany()
                        .HasForeignKey("CoverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LiftoffProject.Models.TimeToBeat", b =>
                {
                    b.HasOne("LiftoffProject.Models.Game")
                        .WithOne("TimeToBeat")
                        .HasForeignKey("LiftoffProject.Models.TimeToBeat", "LocalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
