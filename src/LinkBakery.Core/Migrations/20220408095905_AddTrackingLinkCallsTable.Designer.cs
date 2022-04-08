﻿// <auto-generated />
using System;
using LinkBakery.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LinkBakery.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220408095905_AddTrackingLinkCallsTable")]
    partial class AddTrackingLinkCallsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LinkBakery.Core.Models.TrackingLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrackingLinks");
                });

            modelBuilder.Entity("LinkBakery.Core.Models.TrackingLinkCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TrackingLinkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackingLinkId");

                    b.ToTable("TrackingLinkCalls");
                });

            modelBuilder.Entity("LinkBakery.Core.Models.TrackingLinkCall", b =>
                {
                    b.HasOne("LinkBakery.Core.Models.TrackingLink", "TrackingLink")
                        .WithMany()
                        .HasForeignKey("TrackingLinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrackingLink");
                });
#pragma warning restore 612, 618
        }
    }
}
