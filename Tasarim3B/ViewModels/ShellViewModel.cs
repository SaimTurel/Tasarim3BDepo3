using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Tasarim3B.Contracts.Services;
using Tasarim3B.Ortak.ViewModels;

namespace Tasarim3B.ViewModels;

public partial class ShellViewModel : ObservableObject
{
    #region Kurucu
    public ShellViewModel(IRightPaneService rightPaneService)
    {
        _rightPaneService = rightPaneService;
    }
    #endregion Kurucu

    #region Alanlar
    private readonly IRightPaneService _rightPaneService;

    #endregion Alanlar

    #region Özellikler

    [ObservableProperty]
    private ObservableCollection<BelgeVM> belgeler;

    #endregion Özellikler

    #region Komutlar

    private ICommand _loadedCommand;
    private ICommand _unloadedCommand;

    //public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new RelayCommand(OnLoaded));
    [RelayCommand]
    private void YeniCizimEkle()
    {
        int yenicizimno = Belgeler.Count(c => c.Adi.StartsWith("Yeni Çizim")) + 1;
        ////var yenicizim = new CizimVM("Yeni Çizim-" + (Belgeler.Count(c => c.Adi.StartsWith("Yeni Çizim")) + 1) + "*");
        //var yenicizim = new CizimVM("Yeni Çizim-" + yenicizimno + "*");

        //yenicizim.ToolTip = yenicizim.Adi + " çizim penceresi";
        //Belgeler.Add(yenicizim);
        //ActiveDocument = Belgeler.Last();
    }


    public ICommand UnloadedCommand => _unloadedCommand ?? (_unloadedCommand = new RelayCommand(OnUnloaded));

   
    private void OnLoaded()
    {
    }

    private void OnUnloaded()
    {
        _rightPaneService.CleanUp();
    }



    #endregion
}
