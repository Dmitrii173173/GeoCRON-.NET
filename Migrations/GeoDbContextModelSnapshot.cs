﻿// <auto-generated />
using System;
using GeoCRON.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeoCRON.Migrations
{
    [DbContext(typeof(GeoDbContext))]
    partial class GeoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeoCRON.Models.GeoInfo", b =>
                {
                    b.Property<Guid>("IpLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Readme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IpLocal");

                    b.ToTable("GeoInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
