using Microsoft.EntityFrameworkCore;
using Tasarim3B.Veri.Erisim.AltYapi.EF.Temel;
using Tasarim3B.Veri.Erisim.Arayuzler;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Erisim.AltYapi.EF
{
    public class EfIsletmeErisim : EfEntityRepositoryBase<Isletme, Tasarim3BDBContext>, IIsletmeErisim
    {
        
        public List<Isletme> GetAll()
        {
            return GetList();
            //using (Tasarim3BDBContext context=new())
            //{

            //}
        }

        public List<Isletme> Get(int id)
        {
            
            return GetList(i => i.ID == id);
        }

        public List<Isletme> GetByLevhalarInclude(int id)
        {
            using (Tasarim3BDBContext context = new())
            {
                var isletme = (from c in context.Firmalar where c.ID == id select c).Include(c => c.Levhalar);
                            
            }
            return GetList(i => i.ID == id);
        }

        //public Isletme GetByIDLevhalarYukle(int id)
        //{
        //    //var donen = Get(from frm in Isletme select frm.ID);
        //    Isletme? isletme;
        //    using (Tasarim3BDBContext context = new())
        //    {
        //        isletme = context.Firmalar.FirstOrDefault(c => c.ID == id);
        //        //isletme = firmalar.FirstOrDefault<Isletme>(c => c.ID == id);
        //        return isletme;

        //    }
        //}
    }
}
