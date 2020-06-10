using Loppprojekt.Data.Cars.Models;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars.Models
{
    public sealed class Model : Entity<ModelData>
    {
        public Model() : this(null) { }
        public Model(ModelData d) : base(d) { }
    }
}
