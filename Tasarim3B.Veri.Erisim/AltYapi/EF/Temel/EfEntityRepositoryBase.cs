
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Tasarim3B.Veri.Erisim.Arayuzler;
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Erisim.AltYapi.EF.Temel
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
    where TContext : DbContext, new()
    {
       
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            using (var context = new TContext())
            {
                return expression == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }

        public TEntity GetByInclude(Expression<Func<TEntity, bool>> expression)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public int MaxID()
        {
            var liste = GetList();
            if (liste.Count > 0)
                return liste.Max(c => c.ID);
            else
                return 0;
        }
    }

}
