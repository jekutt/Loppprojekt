using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Models;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Models
{
    public class CreateModel : ModelsPage
    {
        public CreateModel(IModelsRepository r, IMarksRepository m) : base(r, m)
        {
        }

        public IActionResult OnGet(string fixedFilter, string fixedValue)
        {
            FixedFilter = fixedFilter;
            FixedValue = fixedValue;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            if (!await addObject(fixedFilter, fixedValue)) return Page();
            return Redirect(IndexUrl);
        }
    }
}
