using System.Collections.Generic;
using Loppprojekt.Data.Cars.Models;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Facade.Cars.Models;
using Loppprojekt.Pages.Common;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Loppprojekt.Pages.Cars.Models
{
    public abstract class ModelsPage : BasePage<IModelsRepository, Model, ModelView, ModelData>
    {
        protected internal ModelsPage(IModelsRepository r, IMarksRepository m) : base(r)
        {
            PageTitle = "Models";
            Marks = createMarks(m);
        }

        private static IEnumerable<SelectListItem> createMarks(IMarksRepository r)
        {
            var list = new List<SelectListItem>();
            var marks = r.Get().GetAwaiter().GetResult();
            foreach (var m in marks)
            {
                list.Add(new SelectListItem(m.Data.Name, m.Data.Name));
            }
            return list;
        }

        public IEnumerable<SelectListItem> Marks { get; }

        public override string ItemId => Item?.Name ?? string.Empty;

        protected internal override string getPageUrl() => "/Cars/Models";

        protected internal override string getPageSubTitle()
        {
            return FixedValue is null ?
                base.getPageSubTitle()
                : $"For {GetMarkName(FixedValue)}";
        }

        protected internal override Model toObject(ModelView view)
        {
            return ModelViewFactory.Create(view);
        }

        protected internal override ModelView toView(Model obj)
        {
            return ModelViewFactory.Create(obj);
        }
        public string GetMarkName(string markId)
        {
            foreach (var m in Marks)
                if (m.Value == markId)
                    return m.Text;
            return "Unspecified";
        }
    }
}
