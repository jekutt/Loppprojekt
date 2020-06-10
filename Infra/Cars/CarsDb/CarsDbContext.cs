using Loppprojekt.Data.Cars.Generations;
using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Data.Cars.Models;
using Microsoft.EntityFrameworkCore;

namespace Loppprojekt.Infra.Cars.CarsDb
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options)
            : base(options)
        {
        }

        public DbSet<MarkData> Marks { get; set; }
        public DbSet<ModelData> Models { get; set; }
        public DbSet<GenerationData> Generations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MarkData>().ToTable(nameof(Marks)).HasKey(x => x.Name);
            builder.Entity<ModelData>().ToTable(nameof(Models)).HasKey(x => x.Name);
            builder.Entity<GenerationData>().ToTable(nameof(Generations)).HasKey(x => x.Name);
        }
    }
}
