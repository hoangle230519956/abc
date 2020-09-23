using DUANVNPT.Entities;
using DUANVNPT.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUANVNPT.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //đỗ dữ liệu tĩnh 
            modelBuilder.Entity<AppConfig>().HasData(new AppConfig()
            {
                Key = "HomeTile",
                Value = "This is home page Du An VNPT"
            });

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "Tiếng Anh", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                    new Category()
                    {
                        Id= 1,
                        IsShowOnHome = true,
                        SortOrder = 1,
                        ParentId = null,
                        Status = Status.Active,
                    },      
                     new Category()
                     {
                         Id =2,
                         IsShowOnHome = true,
                         SortOrder = 2,
                         ParentId = null,
                         Status = Status.Active,                   
                 });
            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id=1,
                    CategoryId =1,
                    Name = "Áo Nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm thời trang nam",
                    SeoTitle = "Sản phẩm thời trang nam"
                },
                new CategoryTranslation()
                {
                    Id=2,
                    CategoryId=2,
                    Name = "Áo Nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm thời trang nu",
                    SeoTitle = "Sản phẩm thời trang nu"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id=1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 20000, Stock = 0,
                    ViewCount = 0,                
                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id=1,
                     ProductId=1,
                     Name = "Áo Sơ Mi Nam Việt Tiến ",
                     LanguageId = "vi-VN",
                     SeoAlias = "ao-so-mi-nam-viet-tien",
                     SeoDescription = "Sản phẩm thời trang nam",
                     SeoTitle = "Sản phẩm thời trang nam",
                     Details = "Mô tả sản phẩm",
                     Description = ""
                 }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId=1, CategoryId = 1 }
                );
        }
    }
}
