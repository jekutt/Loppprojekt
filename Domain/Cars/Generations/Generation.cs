using Loppprojekt.Data.Cars.Generations;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars.Generations
{
    public sealed class Generation : Entity<GenerationData>
    {
        public Generation() : this(null) { }
        public Generation(GenerationData d) : base(d) { }
    }
}
