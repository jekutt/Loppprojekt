using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Infra.Cars.CarsDb;
using Loppprojekt.Infra.Common;

namespace Loppprojekt.Infra.Cars.Marks
{
    public class MarksRepository : UniqueEntityRepository<Mark, MarkData>, IMarksRepository
    {
        public MarksRepository(CarsDbContext c) : base(c, c.Marks) { }

        protected internal override Mark toDomainObjects(MarkData d) => new Mark(d);
        
    }
}
