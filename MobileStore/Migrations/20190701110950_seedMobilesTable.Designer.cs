﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileStore.Models;

namespace MobileStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190701110950_seedMobilesTable")]
    partial class seedMobilesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MobileStore.Models.Mobile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullDescription");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsMobileOfTheDay");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("TinyDescription");

                    b.HasKey("Id");

                    b.ToTable("Mobiles");

                    b.HasData(
                        new
                        {
                            Id = 102,
                            IsMobileOfTheDay = false,
                            Name = "RedmiGO",
                            Price = 4500m,
                            TinyDescription = "Smart Mobile Under Budget"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
