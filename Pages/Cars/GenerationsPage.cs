using System.Collections.Generic;
using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Facade.Cars;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Loppprojekt.Pages.Cars
{
    public abstract class GenerationsPage : BasePage<IGenerationsRepository, Generation, GenerationView, GenerationData>
    {
        protected internal GenerationsPage(IGenerationsRepository r, IModelsRepository m, IMarksRepository s) : base(r)
        {
            PageTitle = "Generations";
            Models = createModels(m);
            Marks = createMarks(s);
        }

        private static IEnumerable<SelectListItem> createModels(IModelsRepository r)
        {
            var list = new List<SelectListItem>();
            var models = r.Get().GetAwaiter().GetResult();
            foreach (var m in models)
            {
                list.Add(new SelectListItem(m.Data.Name, m.Data.Name));
            }
            return list;
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

        public IEnumerable<SelectListItem> Models { get; }
        public IEnumerable<SelectListItem> Marks { get; }

        public override string ItemId => Item?.Name ?? string.Empty;

        protected internal override string getPageUrl() => "/Cars/Generations";

        protected internal override string getPageSubTitle()
        {
            return FixedValue is null ?
                base.getPageSubTitle()
                : $"For {GetModelName(FixedValue)}";
        }

        protected internal override Generation toObject(GenerationView view)
        {
            return GenerationViewFactory.Create(view);
        }

        protected internal override GenerationView toView(Generation obj)
        {
            return GenerationViewFactory.Create(obj);
        }
        public string GetModelName(string modelsId)
        {
            foreach (var m in Models)
                if (m.Value == modelsId)
                    return m.Text;
            return "Unspecified";
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
