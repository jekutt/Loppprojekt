using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Facade.Cars;

namespace Loppprojekt.Pages.Cars
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
