using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Fluent;

using MahApps.Metro.Controls;

using Tasarim3B.Behaviors;
using Tasarim3B.Contracts.Services;
using Tasarim3B.Contracts.Views;
using Tasarim3B.ViewModels;

namespace Tasarim3B.Views;

public partial class ShellWindow : MetroWindow, IShellWindow, IRibbonWindow
{
    public RibbonTitleBar TitleBar
    {
        get => (RibbonTitleBar)GetValue(TitleBarProperty);
        private set => SetValue(TitleBarPropertyKey, value);
    }

    private static readonly DependencyPropertyKey TitleBarPropertyKey = DependencyProperty.RegisterReadOnly(nameof(TitleBar), typeof(RibbonTitleBar), typeof(ShellWindow), new PropertyMetadata());

    public static readonly DependencyProperty TitleBarProperty = TitleBarPropertyKey.DependencyProperty;

    public ShellWindow(IPageService pageService, ShellViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        navigationBehavior.Initialize(pageService);
    }

    //public Frame GetNavigationFrame()
    //    => shellFrame;

    //public Frame GetRightPaneFrame()
    //    => rightPaneFrame;

    //public SplitView GetSplitView()
    //    => splitView;

    public void ShowWindow()
        => Show();

    public void CloseWindow()
        => Close();

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
        var window = sender as MetroWindow;
        TitleBar = window.FindChild<RibbonTitleBar>("RibbonTitleBar");
        TitleBar.InvalidateArrange();
        TitleBar.UpdateLayout();

        var tabBehavior = window.FindChild<RibbonTabsBehavior>("tabsBehavior") as RibbonTabsBehavior;

    }

    private void OnUnloaded(object sender, RoutedEventArgs e)
    {
        //tabsBehavior.Unsubscribe();
    }

    public RibbonTabsBehavior GetRibbonTabsBehavior()
    {
        var tabsBehavior = this.FindChild<RibbonTabsBehavior>("tabsBehavior");
        return tabsBehavior;
        /*=> tabsBehavior;*/
    }
}
