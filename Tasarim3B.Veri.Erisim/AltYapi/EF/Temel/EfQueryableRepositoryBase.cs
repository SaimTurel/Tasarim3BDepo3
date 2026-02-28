
using Microsoft.EntityFrameworkCore;
using Tasarim3B.Veri.Temel.VeriErisim;
using Tasarim3B.Veri.Varliklar.Arayuzler;

namespace Tasarim3B.Veri.Erisim.Temel.EF.Temel
{

    public class EfQueryableRepositoryBase<T>(DbContext context) : IQueryableRepository<T>
            where T : class, IEntity, new()
    {
        private DbSet<T>? _entities;
        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities => _entities ??= context.Set<T>();

        //private string sorgu=
        //public Isletme FirmaGetir(int id) =>context.
        //Table.Where(c=>c.ID ==id).Select(d=>d).Include(e=>e.l"Levhalar")
        //    (from c in Table where c.ID == id select).Include(x => x.Firma);

        /* Table.Where (c=>c.ID==id).Include<Levha>(c=>c.IsletmeId);*/
        //public IQueryable<T> Levhalar=>this.Entities.Include()
    }

    //public class EfQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    //{
    //    private DbContext _context;
    //    private DbSet<T> _entities;
    //    public EfQueryableRepository(DbContext context)
    //    {
    //        _context = context;
    //    }

    //    public IQueryable<T> Table => Entities;

    //    protected virtual DbSet<T> Entities
    //    {
    //        get { return _entities ?? (_entities = _context.Set<T>()); }
    //    }
    //}

}
