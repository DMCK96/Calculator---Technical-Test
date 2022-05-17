using Microsoft.EntityFrameworkCore;
using GLTechnicalTest.Models;

namespace GLTechnicalTest.Data
{
    public class CalculatorContext : DbContext
    {
        public DbSet<ResultModel> Results { get; set; }
    }
}
