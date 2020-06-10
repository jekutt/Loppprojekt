using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Cars.Marks;

namespace Loppprojekt.Facade.Cars.Marks
{
    public static class MarkViewFactory
    {
        public static Mark Create(MarkView v)
        {
            var o = new Mark();
            Copy.Members(v, o.Data);

            return o;
        }
        public static MarkView Create(Mark o)
        {
            var v = new MarkView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}

