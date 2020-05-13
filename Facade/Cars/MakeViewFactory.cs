using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Cars;

namespace Loppprojekt.Facade.Cars
{
    public static class MakeViewFactory
    {
        public static Make Create(MakeView v)
        {
            var o = new Make();
            Copy.Members(v, o.Data);

            return o;
        }
        public static MakeView Create(Make o)
        {
            var v = new MakeView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
