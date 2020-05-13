using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Common;

namespace Loppprojekt.Domain.Cars
{
    public sealed class Make : Entity<MakeData>
    {
        public Make() : this(null) { }

        public Make(MakeData data) : base(data) { }
    }
}
