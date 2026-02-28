
using Tasarim3B.Veri.Erisim.AltYapi.EF.Temel;
using Tasarim3B.Veri.Erisim.Arayuzler;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Erisim.AltYapi.EF
{
    public class EfLevhaErisim : EfEntityRepositoryBase<Levha, Tasarim3BDBContext>, ILevhaErisim
    {
        public List<Levha> GetAll()
        {
            return GetList();
        }

        public List<Levha> Get(int id)
        {
            return GetList(i => i.ID == id);
        }

        //public int GetMaxID()
        //{
        //    var LevhalarList = GetList();
        //    if (LevhalarList.Count > 0)
        //        return LevhalarList.Max(c => c.ID);
        //    else
        //        return 0;
        //} 
    }
}
