using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars
{
    public class ModelsRepository : UniqueEntityRepository<Model, ModelData>, IModelsRepository
    {
        public ModelsRepository(CarsDbContext c) : base(c, c.Models) { }

        protected internal override Model toDomainObjects(ModelData d) => new Model(d);

    }
}
