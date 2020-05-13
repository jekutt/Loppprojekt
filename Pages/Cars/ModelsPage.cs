using System.Collections.Generic;
using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Facade.Cars;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Loppprojekt.Pages.Cars
{
    public abstract class ModelsPage : BasePage<IModelsRepository, Model, ModelView, ModelData>
    {
        protected internal ModelsPage(IModelsRepository r, IMakesRepository m) : base(r)
        {
            PageTitle = "Models";
            Makes = createMakes(m);
        }

        private static IEnumerable<SelectListItem> createMakes(IMakesRepository r)
        {
            var list = new List<SelectListItem>();
            var makes = r.Get().GetAwaiter().GetResult();
            foreach (var m in makes)
            {
                list.Add(new SelectListItem(m.Data.Name, m.Data.Id));
            }
            return list;
        }

        public IEnumerable<SelectListItem> Makes { get; }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string getPageUrl() => "/Cars/Models";

        protected internal override string getPageSubTitle()
        {
            return FixedValue is null ?
                base.getPageSubTitle()
                : $"For {GetMakeName(FixedValue)}";
        }

        protected internal override Model toObject(ModelView view)
        {
            return ModelViewFactory.Create(view);
        }

        protected internal override ModelView toView(Model obj)
        {
            return ModelViewFactory.Create(obj);
        }
        public string GetMakeName(string makeId)
        {
            foreach (var m in Makes)
                if (m.Value == makeId)
                    return m.Text;
            return "Unspecified";
        }
    }
}
