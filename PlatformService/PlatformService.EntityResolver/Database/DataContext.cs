using System;
using Microsoft.EntityFrameworkCore;
using PlatformService.EntityResolver.Database.Models;

namespace PlatformService.EntityResolver.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<PlatformModel> platformModels { get; set; }
    }
}
