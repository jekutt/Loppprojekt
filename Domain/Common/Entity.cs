using Loppprojekt.Data.Common;

namespace Loppprojekt.Domain.Common
{
    public abstract class Entity<TData> where TData: PeriodData, new()
    {
        protected internal Entity(TData d = null) => Data = d ?? new TData();
        public TData Data { get; set; }

    }
}