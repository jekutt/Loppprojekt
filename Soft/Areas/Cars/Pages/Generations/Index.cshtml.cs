using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Generations;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Generations;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Generations
{
    public class IndexModel : GenerationsPage
    {
        public IndexModel(IGenerationsRepository r, IModelsRepository m) : base(r, m) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

