using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars.Marks
{
    public sealed class Mark : Entity<MarkData>
    {
        public Mark() : this(null) { }

        public Mark(MarkData data) : base(data) { }
    }
}
