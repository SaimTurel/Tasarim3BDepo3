

using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Islem.Arayuzler
{
    public interface IIsletmeIslem
    {
        List<Isletme> GetAll();
        Isletme GetByID(int id);
        Isletme Add(Isletme isletme);
        Isletme Update(Isletme isletme);
        void Delete(Isletme isletme);
    }
}
