using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;
using System.Windows.Media;
using Tasarim3B.Hizmet.Arayuzler.Genel;
using Tasarim3B.Ortak.ViewModels.Docking;

namespace Tasarim3B.Ortak.ViewModels;

public  partial  class BelgeVM : PaneVM, IBelgeVM
{
    #region Kurucu

    public BelgeVM()
    {
        isDirty = true;
        Title = string.Empty;
        Adi = "Adsýz";
        IconSource = ISC.ConvertFromInvariantString(@"pack://application:,,/Resimler/document.png") as ImageSource;
        //IconSource= ISC.ConvertFromInvariantString(@"/Tasarim3B;component/Resimler/document.png") as ImageSource;
    }

    public BelgeVM(string adi)
    {
        Adi = adi;
        Title = adi;
    }
    #endregion Kurucu

    #region Alanlar

    private static ImageSourceConverter ISC = new ImageSourceConverter();

    #endregion Alanlar

    #region IBelgeVM 

    [ObservableProperty]
    private bool isDirty;

    [ObservableProperty]
    private string adi;

    [ObservableProperty]
    private string toolTip;

    [RelayCommand]
    public void Save()
    {


    }

    [RelayCommand]
    public void SaveAs()
    {

    }

    [RelayCommand]
    public virtual void Close()
    {

    }

    [RelayCommand]
    public void BaslikKeyDown()
    {

    }

    [RelayCommand]
    public void LostFocus()
    {

    }

    [RelayCommand]
    public void MouseDoubleClick()
    {

    }


    #endregion IBelgeVM 

}
