using DUANVNPT.Entities;
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
            modelBuilder.Entity<AppConfig>().HasData(new AppConfig()
            {
                Key = "HomeTile",
                Value = "This is home page Du An VNPT"
            });
        }
    }
}
