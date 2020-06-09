using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars
{
    public sealed class Mark : Entity<MarkData>
    {
        public Mark() : this(null) { }

        public Mark(MarkData data) : base(data) { }
    }
}
