using System.Windows.Controls;

using MahApps.Metro.Controls;

using Tasarim3B.Behaviors;

namespace Tasarim3B.Contracts.Views;

public interface IShellWindow
{
    

    void ShowWindow();

    void CloseWindow();

    //Frame GetNavigationFrame();
    //Frame GetRightPaneFrame();

    //SplitView GetSplitView();

    RibbonTabsBehavior GetRibbonTabsBehavior();
}
