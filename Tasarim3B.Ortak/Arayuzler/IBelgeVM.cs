
using Tasarim3B.Ortak.Arayuzler;

namespace Tasarim3B.Hizmet.Arayuzler.Genel;

public interface IBelgeVM : IPaneVM
{
    bool IsDirty { get; set; }
    string Adi { get; set; }
    string ToolTip { get; set; }    
    void Save();
    void SaveAs();
    void Close();
    void BaslikKeyDown();
    void LostFocus();
    void MouseDoubleClick();
}
