using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Marks;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Marks
{
    public class DetailsModel : MarksPage
    {
        public DetailsModel(IMarksRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }

    }

}
