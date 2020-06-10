using Loppprojekt.Data.Common;

namespace Loppprojekt.Data.Cars.Generations
{
    public sealed class GenerationData : DefinedEntityData
    {
        public string MarkId { get; set; }
        public string ModelsId { get; set; }
        public string BodyType { get; set; }
        public string DrivenWheel { get; set; }

    }
}
