using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars
{
    public class MakesRepository : UniqueEntityRepository<Make, MakeData>, IMakesRepository
    {
        public MakesRepository(CarsDbContext c) : base(c, c.Makes) { }

        protected internal override Make toDomainObjects(MakeData d) => new Make(d);

    }
}
