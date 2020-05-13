﻿using Loppprojekt.Aids.Methods;
using Loppprojekt.Domain.Cars;

namespace Loppprojekt.Facade.Cars
{
    public static class ModelViewFactory
    {
        public static Model Create(ModelView v)
        {
            var o = new Model();
            Copy.Members(v, o.Data);

            return o;
        }

        public static ModelView Create(Model o)
        {
            var v = new ModelView();
            Copy.Members(o.Data, v);

            return v;
        }
    }
}
