using Loppprojekt.Data.Common;

namespace Loppprojekt.Data.Cars
{
    public sealed class ModelFactorData : PeriodData
    {
        public string ModelId { get; set; }
        public string SystemOfModelsId { get; set; }
        public double Factor { get; set; }
    }
}
