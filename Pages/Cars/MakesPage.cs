using Loppprojekt.Data.Cars;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Facade.Cars;

namespace Loppprojekt.Pages.Cars
{
    public abstract class MakesPage : BasePage<IMakesRepository, Make, MakeView, MakeData>
    {
        protected internal MakesPage(IMakesRepository r) : base(r)
        {
            PageTitle = "Makes";
        }

        public override string ItemId => Item?.Id ?? string.Empty;
        protected internal override string getPageUrl() => "/Cars/Makes";

        protected internal override Make toObject(MakeView view)
        {
            return MakeViewFactory.Create(view);
        }

        protected internal override MakeView toView(Make obj)
        {
            return MakeViewFactory.Create(obj);
        }
    }
}
