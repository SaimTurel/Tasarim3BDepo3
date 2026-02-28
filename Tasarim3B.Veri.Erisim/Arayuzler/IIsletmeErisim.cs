

using Microsoft.EntityFrameworkCore;
using Tasarim3B.Veri.Varliklar.Arayuzler;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Erisim.Arayuzler
{
    public interface IIsletmeErisim : IEntityRepository<Isletme>
    {
        List<Isletme> GetAll();
        List<Isletme> Get(int id);
        //public Isletme GetByIDLevhalarYukle(int id);

    }

    //public interface ILevhaErisim : IEntityRepository<Levha>
    //{
    //    List<Levha> GetAll();
    //    List<Levha> Get(int id);
    //}

}
    //public interface IErisim<TEntity>:IEntityRepository<TEntity>
    //    where TEntity :class, IEntity,new()
    //{

    //}

//    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
//where TEntity : class, IEntity, new()
//where TContext : DbContext, new()


