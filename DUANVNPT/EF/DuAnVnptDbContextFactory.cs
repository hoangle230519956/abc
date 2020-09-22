using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DUANVNPT.EF
{
    public class DuAnVnptDbContextFactory : IDesignTimeDbContextFactory<ESHOPDbContent>
    {
        public ESHOPDbContent CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsetting.json")
               .Build();

            var connectionString = configuration.GetConnectionString("DuAnVNPTDb");

            var optionsBuilder = new DbContextOptionsBuilder<ESHOPDbContent>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ESHOPDbContent(optionsBuilder.Options);
        }
    }
}
