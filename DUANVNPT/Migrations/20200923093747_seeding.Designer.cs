﻿// <auto-generated />
using System;
using DUANVNPT.EF;
using DUANVNPT.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DUANVNPT.Migrations
{
    [DbContext(typeof(ESHOPDbContent))]
    [Migration("20200923093747_seeding")]
    partial class seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DUANVNPT.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Key");

                    b.ToTable("AppConfig");

                    b.HasData(
                        new { Key = "HomeTile", Value = "This is home page Du An VNPT" }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DUANVNPT.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsShowOnHome");

                    b.Property<int?>("ParentId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, IsShowOnHome = true, SortOrder = 1, Status = 1 },
                        new { Id = 2, IsShowOnHome = true, SortOrder = 2, Status = 1 }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.CategoryTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(500);

                    b.Property<string>("SeoTitle")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryTranslations");

                    b.HasData(
                        new { Id = 1, CategoryId = 1, LanguageId = "vi-VN", Name = "Áo Nam", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm thời trang nam", SeoTitle = "Sản phẩm thời trang nam" },
                        new { Id = 2, CategoryId = 2, LanguageId = "vi-VN", Name = "Áo Nữ", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm thời trang nu", SeoTitle = "Sản phẩm thời trang nu" }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("DUANVNPT.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new { Id = "vi-VN", IsDefault = true, Name = "Tiếng Việt" },
                        new { Id = "en-US", IsDefault = false, Name = "Tiếng Anh" }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("ShipAddress");

                    b.Property<string>("ShipEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ShipName");

                    b.Property<string>("ShipPhoneNumber");

                    b.Property<int>("Status");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DUANVNPT.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DUANVNPT.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<decimal>("OriginalPrice");

                    b.Property<decimal>("Price");

                    b.Property<int>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new { Id = 1, DateCreated = new DateTime(2020, 9, 23, 16, 37, 46, 996, DateTimeKind.Local), OriginalPrice = 100000m, Price = 20000m, Stock = 0, ViewCount = 0 }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.ProductInCategory", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("ProductId");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductInCategories");

                    b.HasData(
                        new { CategoryId = 1, ProductId = 1 }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.ProductTranslation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Details")
                        .HasMaxLength(500);

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("ProductId");

                    b.Property<string>("SeoAlias")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoTitle");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTranslations");

                    b.HasData(
                        new { Id = 1, Description = "", Details = "Mô tả sản phẩm", LanguageId = "vi-VN", Name = "Áo Sơ Mi Nam Việt Tiến ", ProductId = 1, SeoAlias = "ao-so-mi-nam-viet-tien", SeoDescription = "Sản phẩm thời trang nam", SeoTitle = "Sản phẩm thời trang nam" }
                    );
                });

            modelBuilder.Entity("DUANVNPT.Entities.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ApplyForAll");

                    b.Property<decimal?>("DiscountAmount");

                    b.Property<int?>("DiscountPercent");

                    b.Property<DateTime>("FromDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ProductCategoryIds");

                    b.Property<string>("ProductIds");

                    b.Property<int>("Status");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("Id");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DUANVNPT.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("ExternalTransactionId");

                    b.Property<decimal>("Fee");

                    b.Property<string>("Message");

                    b.Property<string>("Provider");

                    b.Property<string>("Result");

                    b.Property<int>("Status");

                    b.Property<DateTime>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("DUANVNPT.Entities.Cart", b =>
                {
                    b.HasOne("DUANVNPT.Entities.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DUANVNPT.Entities.CategoryTranslation", b =>
                {
                    b.HasOne("DUANVNPT.Entities.Category", "Category")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DUANVNPT.Entities.Language", "Language")
                        .WithMany("CategoryTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DUANVNPT.Entities.OrderDetail", b =>
                {
                    b.HasOne("DUANVNPT.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DUANVNPT.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DUANVNPT.Entities.ProductInCategory", b =>
                {
                    b.HasOne("DUANVNPT.Entities.Category", "Category")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DUANVNPT.Entities.Product", "Product")
                        .WithMany("ProductInCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DUANVNPT.Entities.ProductTranslation", b =>
                {
                    b.HasOne("DUANVNPT.Entities.Language", "Language")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DUANVNPT.Entities.Product", "Product")
                        .WithMany("ProductTranslations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
