using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Cars;

namespace Loppprojekt.Facade.Cars
{
    public static class GenerationViewFactory
    {
        public static Generation Create(GenerationView v)
        {
            var o = new Generation();
            Copy.Members(v, o.Data);

            return o;
        }

        public static GenerationView Create(Generation o)
        {
            var v = new GenerationView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
