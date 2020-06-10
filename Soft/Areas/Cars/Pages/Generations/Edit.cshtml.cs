using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Domain.Cars.Generations;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Pages.Cars;
using Loppprojekt.Pages.Cars.Generations;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Generations
{
    public class EditModel : GenerationsPage
    {
        public EditModel(IGenerationsRepository r, IModelsRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id, string fixedFilter, string fixedValue)
        {
            await getObject(id, fixedFilter, fixedValue);

            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string fixedFilter, string fixedValue)
        {
            await updateObject(fixedFilter, fixedValue);
            return Redirect(IndexUrl);
        }

    }

}
