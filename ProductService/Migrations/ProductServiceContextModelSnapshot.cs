﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductService;

namespace ProductService.Migrations
{
    [DbContext(typeof(ProductServiceContext))]
    partial class ProductServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("framShop.Core.CategoryInfo", b =>
                {
                    b.Property<int>("CateId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder");

                    b.Property<int>("HasChild");

                    b.Property<int>("Layer");

                    b.Property<string>("Name");

                    b.Property<int>("ParentId");

                    b.Property<string>("Path");

                    b.Property<string>("PriceRange");

                    b.HasKey("CateId");

                    b.ToTable("CategoryInfos");
                });

            modelBuilder.Entity("framShop.Core.ProductImageInfo", b =>
                {
                    b.Property<int>("PImgId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayOrder");

                    b.Property<int>("IsMain");

                    b.Property<int>("Pid");

                    b.Property<string>("ShowImg");

                    b.HasKey("PImgId");

                    b.ToTable("ProductImageInfos");
                });

            modelBuilder.Entity("framShop.Core.ProductInfo", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cateid");

                    b.Property<decimal>("Costprice");

                    b.Property<string>("Description");

                    b.Property<int>("Displayorder");

                    b.Property<bool>("Isbest");

                    b.Property<bool>("Ishot");

                    b.Property<bool>("Isnew");

                    b.Property<int>("Limit");

                    b.Property<decimal>("Marketprice");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<string>("Psn");

                    b.Property<int>("Reviewcount");

                    b.Property<int>("Salecount");

                    b.Property<decimal>("Shopprice");

                    b.Property<string>("Showimg");

                    b.Property<int>("Star");

                    b.Property<int>("State");

                    b.Property<int>("Visitcount");

                    b.Property<int>("Weight");

                    b.Property<DateTime>("_addtime");

                    b.HasKey("Pid");

                    b.ToTable("ProductInfos");
                });
#pragma warning restore 612, 618
        }
    }
}