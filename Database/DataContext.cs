using AutoMapperUse.Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoMapperUse.Homework.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:AutoMapperConnection"]);
        }

        public DbSet<Person> Persons { get; set; }
    }
}
