using System.Windows.Controls;

using Tasarim3B.ViewModels;

namespace Tasarim3B.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
