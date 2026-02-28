
using Tasarim3B.Veri.Erisim.Arayuzler;
using Tasarim3B.Veri.Islem.Arayuzler;
using Tasarim3B.Veri.Varliklar.BasitVarliklar;

namespace Tasarim3B.Veri.Islem.Islemler;

public class LevhaIslem(ILevhaErisim levhaveri) : ILevhaIslem
{
    private ILevhaErisim levhaVeri = levhaveri;

    public List<Levha> GetAll() => levhaVeri.GetAll();
   
    public Levha GetByID(int id)=>levhaVeri.Get(p => p.ID == id);
   
    public Levha Add(Levha levha) =>levhaVeri.Add(levha);
    
    public Levha Update(Levha levha)=>levhaVeri.Update(levha);    

    public void Delete(Levha levha)=>levhaVeri.Delete(levha);    

    public int MaxID() => levhaVeri.MaxID();

    public IEnumerable<Levha> GetByIsletmeID(int isletmeID) => levhaVeri.GetList(c => c.IsletmeID == isletmeID);
    
}
