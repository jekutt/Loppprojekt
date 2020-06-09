using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Pages.Cars;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Generations
{
    public class IndexModel : GenerationsPage
    {
        public IndexModel(IGenerationsRepository r, IModelsRepository m, IMarksRepository s) : base(r, m, s) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

