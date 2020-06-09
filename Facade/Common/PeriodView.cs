using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Loppprojekt.Facade.Common
{
    public abstract class PeriodView
    {
        [DataType(DataType.Date)]
        [DisplayName("Year of manufacture")]
        public DateTime? YearOfManufacture { get; set; }
    }
}