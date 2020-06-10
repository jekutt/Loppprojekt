using Loppprojekt.Data.Cars.Models;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Infra.Cars.CarsDb;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars.Models
{
    public class ModelsRepository : UniqueEntityRepository<Model, ModelData>, IModelsRepository
    {
        public ModelsRepository(CarsDbContext c) : base(c, c.Models) { }

        protected internal override Model toDomainObjects(ModelData d) => new Model(d);

    }
}
