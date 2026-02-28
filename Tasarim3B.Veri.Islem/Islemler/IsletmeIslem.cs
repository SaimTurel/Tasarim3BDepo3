
using Tasarim3B.Veri.Erisim.Arayuzler;
using Tasarim3B.Veri.Islem.Arayuzler;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Islem.Islemler
{
    public class IsletmeIslem : IIsletmeIslem
    {
        public IsletmeIslem(IIsletmeErisim isletmeveri) => isletmeVeri = isletmeveri;

        private IIsletmeErisim isletmeVeri;

        public List<Isletme> GetAll() => isletmeVeri.GetList();
        //public Isletme Get()=>isletmeVeri.Get(d=>d.Levhalar)
        public Isletme GetByID(int id) => isletmeVeri.Get(p => p.ID == id);

        //public Isletme GetByIDLevhalarYukle(int id)=>isletmeVeri.GetByIDLevhalarYukle (id);

        public Isletme Add(Isletme isletme) => isletmeVeri.Add(isletme);

        public Isletme Update(Isletme isletme) => isletmeVeri.Update(isletme);

        public void Delete(Isletme isletme) => isletmeVeri.Delete(isletme);

        public int MaxID() => isletmeVeri.MaxID();

    }
}
