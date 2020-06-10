using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Models;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Models
{
    public class IndexModel : ModelsPage
    {
        public IndexModel(IModelsRepository r, IMarksRepository m) : base(r, m) { }

        public async Task OnGetAsync(string sortOrder, string currentFilter, string searchString,
            int? pageIndex, string fixedFilter, string fixedValue)
        {
            await getList(sortOrder, currentFilter, searchString, pageIndex, fixedFilter, fixedValue);
        }
    }
}

