using System;
using System.Collections.Generic;
using System.Text;
using Loppprojekt.Data.Common;

namespace Loppprojekt.Data.Cars
{
    public sealed class GenerationFactorData : PeriodData
    {
        public string GenerationId { get; set; }
        public string SystemOfGenerationsId { get; set; }
        public string Year
    }
}
