using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Pages.Cars;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Generations
{
    public class CreateModel : GenerationsPage
    {
        public CreateModel(IGenerationsRepository r, IModelsRepository m, IMarksRepository s) : base(r, m, s)
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
