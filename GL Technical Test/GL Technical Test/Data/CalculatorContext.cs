using Microsoft.EntityFrameworkCore;
using GLTechnicalTest.Models;

namespace GLTechnicalTest.Data
{
    public class CalculatorContext : DbContext
    {
        public DbSet<ResultModel> Results { get; set; }

        private readonly string _connectionString;

        public CalculatorContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
