using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Pages.Cars;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Models
{
    public class IndexModel : ModelsPage
    {
        public IndexModel(IModelsRepository r, IMakesRepository m) : base(r, m) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

