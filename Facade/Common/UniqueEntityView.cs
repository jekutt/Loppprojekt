using System.ComponentModel.DataAnnotations;

namespace Loppprojekt.Facade.Common
{
    public abstract class UniqueEntityView : PeriodView
    {
        [Required]
        public string Name { get; set; }
    }
}