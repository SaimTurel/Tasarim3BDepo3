
using System.Windows.Media;

namespace Tasarim3B.Ortak.Arayuzler;

public  interface IPaneVM
{
    string Title { get; set; }
    ImageSource IconSource { get; protected set; }

    string ContentId { get; set; }

    bool IsSelected { get; set; }

    bool IsActive { get; set; }
}
