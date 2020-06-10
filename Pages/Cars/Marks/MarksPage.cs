using Loppprojekt.Data.Cars.Marks;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Facade.Cars.Marks;
using Loppprojekt.Pages.Common;

namespace Loppprojekt.Pages.Cars.Marks
{
    public abstract class MarksPage : BasePage<IMarksRepository, Mark, MarkView, MarkData>
    {
        protected internal MarksPage(IMarksRepository r) : base(r)
        {
            PageTitle = "Marks";
        }

        public override string ItemId => Item?.Name ?? string.Empty;
        protected internal override string getPageUrl() => "/Cars/Marks";

        protected internal override Mark toObject(MarkView view)
        {
            return MarkViewFactory.Create(view);
        }

        protected internal override MarkView toView(Mark obj)
        {
            return MarkViewFactory.Create(obj);
        }
    }
}
