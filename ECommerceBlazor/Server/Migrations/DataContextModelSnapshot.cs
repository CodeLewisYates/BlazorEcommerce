﻿// <auto-generated />
using ECommerceBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceBlazor.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ECommerceBlazor.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "An 85\" smart tv with all the functionality you could think of, watch your favourite films and shows in 4k!",
                            ImageUrl = "https://www.sencor.com/Sencor/media/content/Products/SLE-55US800TCSB-diagonal.jpg",
                            Price = 9.99m,
                            Title = "85 Inch Smart TV UHD (4k)"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Sparkly lava lamp to add a nice effect to any room",
                            ImageUrl = "https://geppettostoybox.com/wp-content/uploads/2020/11/Glitter-Lava-Lamp.jpg",
                            Price = 7.99m,
                            Title = "Lava Lamp"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Why not buy a horse to keep you company, very friendly, eats a lot",
                            ImageUrl = "https://www.yourhorse.co.uk/wp-content/uploads/image-asset.jpg.webp",
                            Price = 5.00m,
                            Title = "Horse"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
