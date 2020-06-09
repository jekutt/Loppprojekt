using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars
{
    public class GenerationsRepository : UniqueEntityRepository<Generation, GenerationData>, IGenerationsRepository
    {
        public GenerationsRepository(CarsDbContext c) : base(c, c.Generations) { }

        protected internal override Generation toDomainObjects(GenerationData d) => new Generation(d);

    }
}
