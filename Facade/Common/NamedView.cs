using System.ComponentModel.DataAnnotations;

namespace Loppprojekt.Facade.Common
{
    public abstract class NamedView : UniqueEntityView
    {
        [Required]
        public string Country { get; set; }
    }
}