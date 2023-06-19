using System;
using System.IO;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PlatformService.EntityResolver.Database
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {

        //public DataContext CreateDbContext(string[] args)
        //{
        //    var configuration = new ConfigurationBuilder()
        //    .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
        //    //.AddJsonFile("appsettings.json")
        //    .Build();

        //    var builder = new DbContextOptionsBuilder<DataContext>();
        //    var connectionString = configuration.GetConnectionString("DbString");
        //    builder.UseNpgsql(connectionString);

        //    return new DataContext(builder.Options);    
        //}
        public DataContext CreateDbContext(string[] args)
        {
            Console.WriteLine("FILEEEEEE",Directory.GetCurrentDirectory());
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            DbContextOptionsBuilder<DataContext> optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new DataContext(optionsBuilder.Options);
        }
    }
}
