using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Loppprojekt.Facade.Common;

namespace Loppprojekt.Facade.Cars.Generations
{
    public sealed class GenerationView : DefinedView
    {
        [Required]
        [DisplayName("Mark")]
        public string MarkId { get; set; }

        [Required]
        [DisplayName("Model")]
        public string ModelsId { get; set; }

        [Required]
        [DisplayName("Body type")]
        public string BodyType { get; set; }

        [Required]
        [DisplayName("Driven wheel")]
        public string DrivenWheel { get; set; }
    }
}
