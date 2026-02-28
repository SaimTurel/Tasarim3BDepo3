

//using Tasarim3B.Hizmet.Arayuzler.Cizim.Levhalar;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Erisim.Arayuzler
{
    public interface ILevhaErisim : IEntityRepository<Levha>
    {
        List<Levha> GetAll();
        List<Levha> Get(int id);
    }
}
