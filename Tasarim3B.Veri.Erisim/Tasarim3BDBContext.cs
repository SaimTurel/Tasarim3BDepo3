
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Erisim
{
    public partial class Tasarim3BDBContext : DbContext
    {

        #region Kurucu
        public Tasarim3BDBContext()
        {
            //var vy = new VeriYonetici();
            BaglantiMetni = VeriYonetici.BaglantiMetni;
            //Database.Initialializer<Tasarim3BDBContext>
            var durum = Database.EnsureCreated();
        }

        public Tasarim3BDBContext(string connectionstring)
            : base()
        {
            DbContextOptionsBuilder opb=new DbContextOptionsBuilder();
            opb.UseSqlite(connectionstring);
            BaglantiMetni = connectionstring;
          
            //Database.EnsureCreated();
        }

        //public VeriTabani(EntityConnection conn)
        //     : base(conn, true)
        //{

        //}

        #endregion Kurucu

        #region Alanlar

        private string BaglantiMetni;

        #endregion Alanlar

        #region Özellikler

        public DbSet<Levha> Levhalar { get; set; }
        public DbSet<Isletme> Firmalar { get; set; }

        #endregion Özellikler

        #region Overrides


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(BaglantiMetni);
            optionsBuilder.UseLazyLoadingProxies();

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Theme>().Navigation(e => e.ColorScheme).AutoInclude();
            modelBuilder.Entity<Isletme>().Navigation(e => e.Levhalar).AutoInclude();
        }
        #endregion Overrides
    }
}
