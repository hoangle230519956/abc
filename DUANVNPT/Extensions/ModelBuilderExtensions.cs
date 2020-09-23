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

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                IsShowOnHome=true, SortOrder=1, ParentId=null,Status = Status.Active,
                CategoryTranslations = new List<CategoryTranslation>()
                {
                    new CategoryTranslation()
                    {
                        Name ="Áo Nam", LanguageId="vi-VN",SeoAlias="ao-nam", SeoDescription="Sản phẩm thời trang nam", SeoTitle="Sản phẩm thời trang nam"
                    }
                }
            });
        }
    }
}
