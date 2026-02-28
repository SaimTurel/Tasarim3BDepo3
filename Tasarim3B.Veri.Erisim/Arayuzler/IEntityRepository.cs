
using System.Linq.Expressions;
using System.Reflection.Metadata;
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Erisim.Arayuzler
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        int MaxID();
    }

}
