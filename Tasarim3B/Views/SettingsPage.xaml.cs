using System.Windows.Controls;

using Tasarim3B.ViewModels;

namespace Tasarim3B.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
