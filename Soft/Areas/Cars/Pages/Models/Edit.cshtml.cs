using System.Threading.Tasks;
using Loppprojekt.Domain.Cars;
using Loppprojekt.Pages.Cars;
using Microsoft.AspNetCore.Mvc;

namespace Loppprojekt.Soft.Areas.Cars.Pages.Models
{
    public class EditModel : ModelsPage
    {
        public EditModel(IModelsRepository r, IMarksRepository m) : base(r, m)
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
