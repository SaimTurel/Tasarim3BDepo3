
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;
using Tasarim3B.Ortak.Arayuzler;

namespace Tasarim3B.Ortak.ViewModels.Docking;

public partial class PaneVM : ObservableObject, IPaneVM
{
    #region Kurucu
    public PaneVM()
    {
        Title = "İsimsiz";
    }

    public PaneVM(string mtitle)
    {
        Title = mtitle;
    }
    #endregion Kurucu

    #region Alanlar

    //[ObservableProperty]
    private string title;
    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    [ObservableProperty]
    private string contentId = null;

    [ObservableProperty]
    private bool isSelected = false;

    [ObservableProperty]
    private bool isActive = false;

    [ObservableProperty]
    private ImageSource iconSource;


    #endregion Alanlar

}
