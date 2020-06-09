using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars
{
    public class MarksRepository : UniqueEntityRepository<Mark, MarkData>, IMarksRepository
    {
        public MarksRepository(CarsDbContext c) : base(c, c.Marks) { }

        protected internal override Mark toDomainObjects(MarkData d) => new Mark(d);
        
    }
}
