using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Loppprojekt.Facade.Common;

namespace Loppprojekt.Facade.Cars
{
    public sealed class GenerationView : DefinedView
    {
        [Required]
        [DisplayName("Mark")]
        public string MarkId { get; set; }

        [Required]
        [DisplayName("Model")]
        public string ModelsId { get; set; }
    }
}
