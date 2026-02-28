using System.Windows.Controls;

using Tasarim3B.ViewModels;

namespace Tasarim3B.Views;

public partial class DataGridPage : Page
{
    public DataGridPage(DataGridViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
