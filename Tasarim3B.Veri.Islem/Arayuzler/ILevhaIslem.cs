
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Islem.Arayuzler
{
    internal interface ILevhaIslem
    {
        List<Levha> GetAll();
        Levha GetByID(int id);
        Levha Add(Levha levha);
        Levha Update(Levha levha);
        void Delete(Levha levha);
        int  MaxID();
        IEnumerable<Levha> GetByIsletmeID(int isletmeID);

    }
}
