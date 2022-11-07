using Microsoft.EntityFrameworkCore;

namespace DataGenerator.Models
{
    public class GenerateContext:DbContext
    {
        public GenerateContext(DbContextOptions<GenerateContext> options) : base(options)
        {

        }

        public DbSet<GeneratedTable> GeneratedTables { get; set; }
        public DbSet<GeneratedField> GeneratedFields { get; set; }

    }
}
