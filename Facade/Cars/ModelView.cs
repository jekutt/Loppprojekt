using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Loppprojekt.Facade.Common;

namespace Loppprojekt.Facade.Cars
{
    public sealed class ModelView : DefinedView
    {
        [Required]
        [DisplayName("Mark")]
        public string MarkId { get; set; }
    }
}
