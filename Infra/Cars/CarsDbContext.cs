using Loppprojekt.Data.Cars;
using Microsoft.EntityFrameworkCore;

namespace Loppprojekt.Infra.Cars
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options)
            : base(options)
        {
        }

        public DbSet<MarkData> Marks { get; set; }
        public DbSet<ModelData> Models { get; set; }
        public DbSet<SystemOfModelsData> SystemsOfModels { get; set; }
        public DbSet<ModelFactorData> ModelFactors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            builder.Entity<MarkData>().ToTable(nameof(Marks)).HasKey(x => x.Name);
            builder.Entity<ModelData>().ToTable(nameof(Models)).HasKey(x => x.Name);
            builder.Entity<SystemOfModelsData>().ToTable(nameof(SystemsOfModels)).HasKey(x => x.Name);
            builder.Entity<ModelFactorData>().ToTable(nameof(ModelFactors)).HasKey(x => new { x.ModelId, x.SystemOfModelsId });
        }
    }
}
