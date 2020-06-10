using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Marks;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Marks
{
    public class IndexModel : MarksPage
    {
        public IndexModel(IMarksRepository r) : base(r) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex,
                fixedFilter, fixedValue);
        }
    }
}

