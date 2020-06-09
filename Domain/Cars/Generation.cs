using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars
{
    public sealed class Generation : Entity<GenerationData>
    {
        public Generation() : this(null) { }
        public Generation(GenerationData d) : base(d) { }
    }
}
