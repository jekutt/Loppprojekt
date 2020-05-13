using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars
{
    public sealed class Model : Entity<ModelData>
    {
        public Model() : this(null) { }
        public Model(ModelData d) : base(d) { }
    }
}
