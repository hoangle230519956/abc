//using DUANVNPT.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUANVNPT.EF
{
    public class ESHOPDbContent : DbContext
    {
        public ESHOPDbContent(DbContextOptions options) : base(options)
        {
        }
        //public DbSet<Products> Products { get; set; }
        //public DbSet<Category> Cotegories { get; set; }
        //public DbSet<AppConfig> AppConfigs { get; set; }


        //public DbSet<Cart> Carts { get; set; }

        //public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        //public DbSet<ProductInCategory> ProductInCategories { get; set; }

        //public DbSet<Contact> Contacts { get; set; }

        //public DbSet<Language> Languages { get; set; }

        //public DbSet<Order> Orders { get; set; }

        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<ProductTranslation> ProductTranslations { get; set; }

        //public DbSet<Promotion> Promotions { get; set; }


        //public DbSet<Transaction> Transactions { get; set; }
    }
}
