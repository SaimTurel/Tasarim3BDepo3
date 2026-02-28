using System.Windows.Controls;

namespace Tasarim3B.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
