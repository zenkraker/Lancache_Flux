﻿// <auto-generated />
using System;
using DeveLanCacheUI_Backend.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeveLanCacheUI_Backend.Migrations
{
    [DbContext(typeof(DeveLanCacheUIDbContext))]
    [Migration("20230822171725_UintChanges")]
    partial class UintChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("DeveLanCacheUI_Backend.Db.DbModels.DbDownloadEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CacheHitBytes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CacheIdentifier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("CacheMissBytes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<uint?>("DownloadIdentifier")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DownloadIdentifierString")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DownloadEvents");
                });

            modelBuilder.Entity("DeveLanCacheUI_Backend.Db.DbModels.DbSetting", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("DeveLanCacheUI_Backend.Db.DbModels.DbSteamDepot", b =>
                {
                    b.Property<uint>("SteamDepotId")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("SteamAppId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SteamDepotId", "SteamAppId");

                    b.ToTable("SteamDepots");
                });

            modelBuilder.Entity("DeveLanCacheUI_Backend.Db.DbModels.DbSteamManifest", b =>
                {
                    b.Property<uint>("DepotId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("ManifestBytesSize")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TotalCompressedSize")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TotalUncompressedSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UniqueManifestIdentifier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DepotId", "CreationTime");

                    b.HasIndex("UniqueManifestIdentifier")
                        .IsUnique();

                    b.ToTable("SteamManifests");
                });
#pragma warning restore 612, 618
        }
    }
}
