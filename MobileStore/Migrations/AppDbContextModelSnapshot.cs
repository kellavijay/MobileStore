﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileStore.Models;

namespace MobileStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ImageThumbUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsMobileOfTheDay");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ProductRelaseDate");

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
                            ProductRelaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TinyDescription = "Smart Mobile Under Budget"
                        },
                        new
                        {
                            Id = 103,
                            IsMobileOfTheDay = false,
                            Name = "RedmiNote5Pro",
                            Price = 11500m,
                            ProductRelaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TinyDescription = "Smart Mobile Under Best Suited for taking pictures"
                        },
                        new
                        {
                            Id = 104,
                            IsMobileOfTheDay = false,
                            Name = "RedmiNote7Pro",
                            Price = 15500m,
                            ProductRelaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TinyDescription = "Smart Mobile With 48 Mega Pixel camera"
                        });
                });

            modelBuilder.Entity("MobileStore.Models.Users", b =>
                {
                    b.Property<int>("uId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("MobileNumber");

                    b.Property<string>("uEmail");

                    b.Property<string>("uName");

                    b.Property<string>("uProfileImageUrl");

                    b.Property<string>("userType");

                    b.HasKey("uId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            uId = 1,
                            MobileNumber = 9030718891.0,
                            uEmail = "kellavijay@gmail.com",
                            uName = "Vijay Kumar",
                            userType = "Admin"
                        },
                        new
                        {
                            uId = 2,
                            MobileNumber = 9030715591.0,
                            uEmail = "ajay@gmail.com",
                            uName = "Ajay Kumar",
                            userType = "Customer"
                        },
                        new
                        {
                            uId = 3,
                            MobileNumber = 9030717791.0,
                            uEmail = "prasad@gmail.com",
                            uName = "Prasad",
                            userType = "Customer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
