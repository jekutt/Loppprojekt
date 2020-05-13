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

        public DbSet<MakeData> Makes { get; set; }
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
            builder.Entity<MakeData>().ToTable(nameof(Makes));
            builder.Entity<ModelData>().ToTable(nameof(Models));
            builder.Entity<SystemOfModelsData>().ToTable(nameof(SystemsOfModels));
            builder.Entity<ModelFactorData>().ToTable(nameof(ModelFactors)).HasKey(x => new { x.ModelId, x.SystemOfModelsId });
        }
    }
}
