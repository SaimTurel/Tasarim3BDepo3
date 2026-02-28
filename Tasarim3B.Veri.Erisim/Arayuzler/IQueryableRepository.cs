
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Temel.VeriErisim
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }

}
