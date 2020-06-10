using Loppprojekt.Data.Cars.Generations;
using Loppprojekt.Domain.Cars.Generations;
using Loppprojekt.Infra.Cars.CarsDb;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars.Generations
{
    public class GenerationsRepository : UniqueEntityRepository<Generation, GenerationData>, IGenerationsRepository
    {
        public GenerationsRepository(CarsDbContext c) : base(c, c.Generations) { }

        protected internal override Generation toDomainObjects(GenerationData d) => new Generation(d);

    }
}
